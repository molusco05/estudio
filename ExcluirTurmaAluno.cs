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
    public partial class ExcluirTurmaAluno : Form
    {
        public ExcluirTurmaAluno()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TurmaAluno ta = new TurmaAluno();
            MySqlDataReader r = ta.consultaTurmaAluno();
            while (r.Read())
            {
               
                comboBox2.Items.Add($"{r["IdTurma"]}");
                

            }
            DAO_Conexao.con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

           
        }

        private void btnExcluir_Click(object sender, EventArgs e)

        {   //exclui da tabela turmaAluno e diminui o numero de alunos na tabela turma
            var cpf = comboBox1.Text;
            var IdTurma = comboBox2.Text;
            TurmaAluno ta = new TurmaAluno(IdTurma, cpf);


            if (ta.excluirTurmaAluno())

            {
                MessageBox.Show("excluido com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao excluir");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurmaAluno t = new TurmaAluno(comboBox2.Text);
            MySqlDataReader m = t.consultarCpf();
            comboBox1.Items.Clear();
            while (m.Read())
            {
                comboBox1.Items.Add($"{m["Cpf"]}");
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
