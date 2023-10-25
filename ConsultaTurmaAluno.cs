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
            TurmaAluno ta = new TurmaAluno();
           // MySqlDataReader r = ta.consultarTurmaAluno(comboBox1.Text);
            //while (r.Read())
            //{
               // dataGridView1.Rows.Add(r["idEstudio_TurmaAluno"].ToString(), r["descricaoModalidade"].ToString());

            //}
            //DAO_Conexao.con.Close();

            //Turma t = new Turma();
           // MySqlDataReader m = t.consultarTodasTurmas();
            //while (m.Read())
           // {
               // comboBox1.Items.Add(m["idTurma"].ToString());

            //}
          //  DAO_Conexao.con.Close();
        }

        private void ConsultaTurmaAluno_Load(object sender, EventArgs e)
        {

        }
    }
    
}
