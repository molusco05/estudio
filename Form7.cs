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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modadlidade m = new Modadlidade(textBox1.Text, float.Parse(txtPreco.Text), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
           
            
                if (m.cadastrarModalidade())
                {
                    MessageBox.Show("cadastrado com secesso!!!");
                }
                else
                {
                    MessageBox.Show("erro ao cadastrar");
                }
            

            
        
    }
    }
}
