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
        int opi;
        public Form8(int op)
        {
            InitializeComponent();


            if (op == 1)
            {
                btnConsultarUma.Text = "consultar uma";
            }
            else
            {
                btnConsultarTodos.Text = "consultar todas";
            }
            opi = op;

            Modadlidade cad = new Modadlidade();
            MySqlDataReader r = cad.consultarTodasModalidade();
            while(r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());

            }
            
            DAO_Conexao.con.Close();

          


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
            MySqlDataReader banc = m.consultarTodasModalidade();


            while (banc.Read())
            {
                dataGridView1.Rows.Add(banc["descricaoModalidade"].ToString(), banc["precoModalidade"].ToString(), banc["qtdeAulas"].ToString(), banc["qtdeAlunos"].ToString());
            }
            DAO_Conexao.con.Close();

          
     
        }

        private void btnConsultarUma_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade();
            MySqlDataReader  banco = m.consultarModalidade(comboBox1.Text);

            //while (banco.Read())
            {
                Console.WriteLine("entrou");
                txtPreco.Text = banco["precoModalidade"].ToString();
                txtAulas.Text = banco["qtdeAulas"].ToString();
                txtAlunos.Text = banco["qtdeAlunos"].ToString();

                    
            }
            DAO_Conexao.con.Close();

        }

        private void Form8_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

