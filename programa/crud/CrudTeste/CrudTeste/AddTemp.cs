using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudTeste
{
    public partial class AddTemp : Form
    {
        public AddTemp()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string stringConnection = "Persist Security Info=False;User ID=sa;Initial Catalog=DBcrudTest;Data Source=DESKTOP-PKIN6P4";
        private string strsql = string.Empty;

        private void AddTemp_Load(object sender, EventArgs e)
        {

        }

        SqlConnection sqlcon = null;
        private string StrCon = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            strsql = "insert into temperaturas(id,contato1,contato2,ambiente,objeto)";
        }
    }
}
