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
        public Form6()
        {
            InitializeComponent();
        }

        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade(txtDescricao.Text);
              if (m.excluirModalidade())
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
    }
}
