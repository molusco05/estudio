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
    public partial class Form6 : Form
    {
        public Form6(int op)
        {
            InitializeComponent();

            Modadlidade cad = new Modadlidade();
            MySqlDataReader r = cad.consultarTodasModalidade();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());

            }

            DAO_Conexao.con.Close();

        }



        
        private void btnExcluir_Click(object sender, EventArgs e)
        {


            Modadlidade m = new Modadlidade();
            if (m.excluirModalidade(comboBox1.Text))
            {
                MessageBox.Show("excluido com secesso!!!");
            }
            else
            {
                MessageBox.Show("erro ao excluir");
            }






        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
