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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Modadlidade od = new Modadlidade();
            MySqlDataReader r = od.consultarTodasModalidade();
            while(r.Read())
            {
                dataGridView1.Rows.Add(r["idEstudio_Modalidade"].ToString(),r["descricaoModalidade"].ToString());

            }
               DAO_Conexao.con.Close();

            Turma t = new Turma();
            MySqlDataReader m = t.consultarTodasTurmas();
            while (m.Read())
            {
                comboBox1.Items.Add(m["idTurma"].ToString());

            }
            DAO_Conexao.con.Close();
        }   
      


        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiaSemana_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Turma t = new Turma(comboBox1.Text, txtModalidade.Text, txtProfessor.Text, txtDiaSemana.Text, txtHora.Text, txtNAlunos.Text);
           


            if (t.cadastrarTurma())

            {
                MessageBox.Show("cadastrado com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var descricao = dataGridView1.SelectedCells[0].Value.ToString();

            Modadlidade mod = new Modadlidade();
            MySqlDataReader r = mod.consultarModalidade(descricao);

            while (r.Read())
            {
                txtModalidade.Text = r["idEstudio_Modalidade"].ToString();
            }

            DAO_Conexao.con.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            Turma t = new Turma(comboBox1.Text, txtModalidade.Text, txtProfessor.Text, txtDiaSemana.Text, txtHora.Text, txtNAlunos.Text);

            if (t.atualizarTurma())

            {
                MessageBox.Show("Atualizado com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao Atualizar");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Turma t = new Turma();
            MySqlDataReader m = t.consultarTurma(comboBox1.Text);
            while (m.Read())
            {
                txtModalidade.Text = m["idModalidade"].ToString();
                txtProfessor.Text = m["professorTurma"].ToString();
                txtDiaSemana.Text = m["diaSemanaTurma"].ToString();
                txtHora.Text = m["horaTurma"].ToString();
                txtNAlunos.Text = m["NalunosMatriculadosTurma"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void txtNAlunos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
