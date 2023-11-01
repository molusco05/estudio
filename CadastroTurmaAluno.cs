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
    public partial class CadastroTurmaAluno : Form
    {
        public CadastroTurmaAluno()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Modadlidade ta = new Modadlidade();
            MySqlDataReader r = ta.consultarModalidade();
            while (r.Read())
            {
                comboBox1.Items.Add(r["IdEstudio_Modalidade"].ToString());

            }
            DAO_Conexao.con.Close();


            Aluno t = new Aluno();
            MySqlDataReader a = t.consultarAluno();
            while (a.Read())
            {
                comboBox2.Items.Add(a["estudio_Aluno"].ToString());

            }
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurmaAluno t = new TurmaAluno();
            MySqlDataReader m = t.cadastrarTurmaAluno(comboBox1.Text);
            while (m.Read())
            {
                comboBox1.Text = m["idModalidade"].ToString();
                
         
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurmaAluno t = new TurmaAluno();
            MySqlDataReader m = t.cadastrarTurmaAluno(comboBox1.Text);
            while (m.Read())
            {
                comboBox2.Text = m["CPFAluno"].ToString();


            }
            DAO_Conexao.con.Close();
        }

        private void CadastroTurmaAluno_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
