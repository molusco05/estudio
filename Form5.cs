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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void lblAlunos_Click(object sender, EventArgs e)
        {

        }
     
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          
          
            Modadlidade m = new Modadlidade(comboBox1.Text, float.Parse(txtPreco.Text), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
         
            
                if (m.atualizarModalidade())
                {
                    MessageBox.Show("atualizado com secesso!!!");
                }
                else
                {
                    MessageBox.Show("erro ao atualizar");
                }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
