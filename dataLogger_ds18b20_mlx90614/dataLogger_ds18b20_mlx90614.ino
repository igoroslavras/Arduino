/* Projeto de pesquisa e extensão desenvolvido na UEMG unidade de Passos
 *  Ferramenta para monitoramento da temperatura nos doceis cafeeiros
*/


/*-----( Import needed libraries )-----*/

#include "RTClib.h"
#include <SPI.h>
#include <SD.h>
#include <Wire.h>
#include <Adafruit_MLX90614.h>

// Get 1-wire Library here: http://www.pjrc.com/teensy/td_libs_OneWire.html
#include <OneWire.h>

//Get DallasTemperature Library here:  http://milesburton.com/Main_Page?title=Dallas_Temperature_Control_Library
#include <DallasTemperature.h>

/*-----( Declare Constants and Pin Numbers )-----*/
#define ONE_WIRE_BUS_PIN 2
//Pino CS do cartao SD
int Pino_CS = 10;

/*-----( Declare objects )-----*/
// Setup a oneWire instance to communicate with any OneWire devices
OneWire oneWire(ONE_WIRE_BUS_PIN);

//Adafruit mlx90614
Adafruit_MLX90614 mlx = Adafruit_MLX90614();

// Pass our oneWire reference to Dallas Temperature.
DallasTemperature sensors(&oneWire);

/*-----( Declare Variables )-----*/
// Assign the addresses of your 1-Wire temp sensors.
// See the tutorial on how to obtain these addresses:
// http://www.hacktronics.com/Tutorials/arduino-1-wire-address-finder.html

DeviceAddress Probe01 = {0x28, 0xFF, 0x20, 0x02, 0xC0, 0x17, 0x01, 0x38 };
DeviceAddress Probe02 = {0x28, 0xFF, 0x63, 0x92, 0xC4, 0x17, 0x04, 0xDF };

RTC_DS1307 rtc;

File file;

void setup()   /****** SETUP: RUNS ONCE ******/
{
  // start serial port to show results
  Serial.begin(9600);
  Serial.print("Initializing Temperature Control Library Version ");
  Serial.println(DALLASTEMPLIBVERSION);

  // Initialize the Temperature measurement library
  sensors.begin();

  // set the resolution to 10 bit (Can be 9 to 12 bits .. lower is faster)
  sensors.setResolution(Probe01, 10);
  sensors.setResolution(Probe02, 10);
  

Serial.print("Número de dispositivos encontrados no barramento = ");
  Serial.println(sensors.getDeviceCount());
  Serial.print("Obtendo temperaturas ... ");

  //Iniciando mlx90614
  Serial.println("Adafruit MLX90614 test");  
  mlx.begin();  

    //Inicia o cartao SD
  Serial.println("Iniciando cartao SD...");
  if (!SD.begin(Pino_CS))
  {
    Serial.println("Falha na inicializacao do SD!");
    return;
  }
  Serial.println("Cartao SD iniciado. OK");
  Serial.println();

  //Verifica as condicoes do RTC
  if (! rtc.begin())
  {
    Serial.println("RTC nao encontrado!");
    while (1);
  }
  if (! rtc.isrunning())
  {
    Serial.println("RTC nao operante!");
    //A linha abaixo ajusta o RTC com a data e hora do momento da compilacao
    rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
    //A linha abaixo permite ajustar manualmente a data e hora do RTC
    //Formato: DateTime(ano, mes, dia, hora, minuto, segundo)
    //rtc.adjust(DateTime(2014, 1, 21, 3, 0, 0));
  }

}//--(end setup )---

void loop()   /****** LOOP: RUNS CONSTANTLY ******/
{
  float contato1, contato2, ambiente, infravermelho;
  
  delay(1000);
  Serial.println();

  // Command all devices on bus to read temperature
  sensors.requestTemperatures();

  Serial.print("Sonda 01:   ");
  printTemperature(Probe01);
  contato1 = sensors.getTempC(Probe01);
  Serial.println();

  Serial.print("Sonda 02:   ");
  printTemperature(Probe02);
  contato2 = sensors.getTempC(Probe02);
  Serial.println();

  ambiente = mlx.readAmbientTempC();
  infravermelho = mlx.readObjectTempC();
  Serial.print("Ambient = "); 
  Serial.print(ambiente);
  Serial.print("*C\tObject = "); 
  Serial.print(infravermelho); 
  Serial.println("*C");
  
  grava_cartao_SD(contato1, contato2, ambiente, infravermelho);
  delay(2000);
  Serial.println();
  Serial.println("Aguardando nova leitura...");
  
}//--(end main loop )---

/*-----( Declare User-written Functions )-----*/
void printTemperature(DeviceAddress deviceAddress)
{

  float tempC = sensors.getTempC(deviceAddress);

  if (tempC == -127.00)
  {
    Serial.print("Error getting temperature  ");
  }
  else
  {
    Serial.print("C: ");
    Serial.print(tempC);
     }//
}// End printTemperature

void grava_cartao_SD(float contato1, float contato2, float ambiente, float infravermelho)
{
  //Abre arquivo no SD para gravacao
  file = SD.open("log.txt", FILE_WRITE);
  //Le as informacoes de data e hora
  DateTime now = rtc.now();
  //Grava os dados no cartao SD
  file.print("Data/hora: ");
  Serial.print(now.day() < 10 ? "0" : "");
  file.print(now.day(), DEC);
  file.print('/');
  file.print(now.month() < 10 ? "0" : "");
  file.print(now.month(), DEC);
  file.print('/');
  file.print(now.year(), DEC);
  file.print(' ');
  file.print(now.hour() < 10 ? "0" : "");
  file.print(now.hour(), DEC);
  file.print(':');
  file.print(now.minute() < 10 ? "0" : "");
  file.print(now.minute(), DEC);
  file.print(':');
  file.print(now.second() < 10 ? "0" : "");
  file.print(now.second(), DEC);
  file.print(' ');
  file.print("- Sensor 1: ");
  file.print(contato1);
  file.print(' ');
  file.print("- Sensor 2: ");
  file.print(contato2);
  file.print("- ambiente: ");
  file.print(ambiente);
  file.print("- Infravermelho: ");
  file.println(infravermelho);
  //Fecha arquivo
  file.close();
}
//*********( THE END )***********
