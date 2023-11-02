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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace estudio
{
    public partial class CadastroTurmaAluno : Form
    {

        
        public CadastroTurmaAluno()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Turma ta = new Turma();
            MySqlDataReader r = ta.consultarTodasTurmas();
            while (r.Read())
            {
                comboBox1.Items.Add($"{r["idTurma"]} - {r["descricao"]}");

            }
            DAO_Conexao.con.Close();


            Aluno t = new Aluno();
            MySqlDataReader a = t.consultarCpf();
            while (a.Read())
            {
                comboBox2.Items.Add(a["CPFAluno"].ToString());

            }
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CadastroTurmaAluno_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var idTurma = comboBox1.Text.Split('-')[0];
            TurmaAluno ta = new TurmaAluno(idTurma, comboBox2.Text);
            


            if (ta.cadastrarTurmaAluno())
            {
                MessageBox.Show("cadastrado com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar");
            }

        }
    }
}
