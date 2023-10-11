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
                dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
                DAO_Conexao.con.Close();
            }

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
            Turma t = new Turma();
            t.cadastrarTurma(txtDiaSemana.Text, txtHora.Text, txtProfessor.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
