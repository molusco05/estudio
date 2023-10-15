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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
           

           Turma cad = new Turma();
            MySqlDataReader r = cad.consultarTodasTurmas();
            while (r.Read())
            {
                comboBox1.Items.Add(r["idModalidade"].ToString());

            }

            DAO_Conexao.con.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultarTodas_Click(object sender, EventArgs e)
        {

            Turma m = new Turma();
            MySqlDataReader banc = m.consultarTodasTurmas();
            dataGridView1.Rows.Clear();

            while (banc.Read())
            {
                
                dataGridView1.Rows.Add(banc["idModalidade"].ToString(), banc["professorTurma"].ToString(), banc["diaSemanaTurma"].ToString(), banc["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Turma m = new  Turma(comboBox1.Text, txtProfessor.Text, txtDiaSemana.Text,txtHora.Text);
            MySqlDataReader banco = m.consultarTurma(); 
            dataGridView1.Rows.Clear();

            while (banco.Read())
            {
                Console.WriteLine("entrou");
              
                dataGridView1.Rows.Add(banco["idModalidade"].ToString(), banco["professorTurma"].ToString(), banco["diaSemanaTurma"].ToString(), banco["horaTurma"].ToString());


            }
            DAO_Conexao.con.Close();
        }
    }
}
