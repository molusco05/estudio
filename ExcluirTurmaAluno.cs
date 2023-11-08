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
                comboBox1.Items.Add($"{r["Cpf"]}" );
                comboBox2.Items.Add($"{r["IdTurma"]}");

            }
            DAO_Conexao.con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cpf = comboBox1.Text.Split('|')[0];
            var idModalidade = comboBox1.Text.Split('|')[1];
            TurmaAluno ta = new TurmaAluno(idModalidade, cpf);


            if (ta.excluirTurmaAluno())

            {
                MessageBox.Show("excluido com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao excluir");
            }
        }
    }
}
