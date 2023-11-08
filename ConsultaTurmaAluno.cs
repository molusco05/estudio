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
    public partial class ConsultaTurmaAluno : Form
    {
        public ConsultaTurmaAluno()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
          
            Turma t = new Turma();
            MySqlDataReader m = t.consultarTodasTurmas();
            while (m.Read())
            {
                comboBox1.Items.Add($"{m["idTurma"]} - {m["descricao"]}");

            }
            DAO_Conexao.con.Close();
        }

        private void ConsultaTurmaAluno_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idTurma = comboBox1.Text.Split('-')[0];
            Turma t = new Turma();
            MySqlDataReader m = t.consultarTurma(idTurma);
            while (m.Read())
            {
                txtHora.Text = m["horaTurma"].ToString();
                txtQntd.Text = m["NalunosMatriculadosturma"].ToString();
                txtDia.Text = m["diaSemanaTurma"].ToString();


            }
            DAO_Conexao.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TurmaAluno ta = new TurmaAluno();
            
            MySqlDataReader r = ta.consultaNomes();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r["nomeAluno"].ToString());

            }
            DAO_Conexao.con.Close();
        }
    }
    
}
   //puxar no id da turma e da modalidade
