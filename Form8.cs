using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();
            Modadlidade m = new Modadlidade();




        }
        //public consultarModalidade(int op)
        //{

        // WindowState = FormWindowState.Maximized;
        //this.op = op;
        // Modadlidade cad = new Modadlidade();
        // MySqlDataReader r = cad.consultarTodasModalidade();
        // while (r.Read())
        //    comboBox1.Items.Add(r["descricaoModalidade"].toString());
        // DAO_Conexao.con.Close();
        // if (op == 2)
        // {
        //    btnAtualizar.Visible = true;
        //  }
        // return op;




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade();
            m.consultarTodasModalidade();
        }

        private void btnConsultarUma_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade();
            m.consultarModalidade();
        }

        private void Form8_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

