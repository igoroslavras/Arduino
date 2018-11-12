using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturasArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SalvaTemperatura(string linha)
        {
            string dia, hora;
            double contato1, contato2, ambiente, objeto;
            //Quebra linha em variaveis
            string[] variaveis = linha.Split(' ');

            contato1 = double.Parse(variaveis[2]) / 100;
            contato2 = double.Parse(variaveis[3]) / 100;
            ambiente = double.Parse(variaveis[4]) / 100;
            objeto = double.Parse(variaveis[5]) / 100;
            MessageBox.Show(objeto.ToString());

            /*for(int index = 0; index <variaveis.Length; index++)
            {
                MessageBox.Show(variaveis[index]);
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seleciona arquivo para abrir
            string linha;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Abrir";
            ofd.Filter = "Documentos de texto (*.txt)|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Abre arquivo
                System.IO.StreamReader file = new System.IO.StreamReader(ofd.FileName);
                while ((linha = file.ReadLine()) != null)
                {
                    SalvaTemperatura(linha);

                }
                file.Close();
            }

        }
    }
}
