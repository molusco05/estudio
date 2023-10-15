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
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
        {
            

            InitializeComponent();

            Turma cad = new Turma();
            MySqlDataReader r = cad.consultarTodasTurmas();

            while (r.Read())
            {
                comboBox1.Items.Add(r["idModalidade"].ToString());
                comboBox2.Items.Add(r["diaSemanaTurma"].ToString());
                comboBox3.Items.Add(r["horaTurma"].ToString());
                comboBox4.Items.Add(r["professorTurma"].ToString());
            }
            DAO_Conexao.con.Close();

            /*
            Turma cadd = new Turma();
            MySqlDataReader rr = cadd.consultarHora();
            comboBox3.Items.Add(rr["horaTurma"].ToString());
            DAO_Conexao.con.Close();

            

            Turma caddd = new Turma();
            MySqlDataReader rrr = caddd.consultarDiaSemana();

            comboBox2.Items.Add(rrr["diaSemanaTurma"].ToString());
            DAO_Conexao.con.Close();
            */
            


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            
            Turma t = new Turma(comboBox1.Text, comboBox4.Text, comboBox2.Text,comboBox3.Text);


            if (t.verificaTurma()) 
            {
                if (t.excluirTurma())

                {
                    MessageBox.Show("excluido com secesso!!!");
                }
                else
                {
                    MessageBox.Show("erro ao excluir");
                }

            }
            else
            {
                MessageBox.Show("nao foi encontrado essa turma");
            }

        }

        private void ExcluirTurma_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblprofesssor_Click(object sender, EventArgs e)
        {

        }
    }
}
