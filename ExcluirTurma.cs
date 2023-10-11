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
            MySqlDataReader r = cad.consultarTodasModalidade();
            
            while (r.Read())
                comboBox1.Items.Add(r["idModalidade"].ToString());
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
            Turma  ex = new Turma();
            ex.excluirTurma();
        }

        private void ExcluirTurma_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
