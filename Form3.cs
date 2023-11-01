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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);

            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já está cadastrado!");
                }
                else
                {
                    textBox2.Focus();
                }

                DAO_Conexao.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] foto = converterFotoParaByteArray();
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox2.Text, textBox3.Text, textBox9.Text, textBox4.Text, textBox10.Text, maskedTextBox2.Text, textBox7.Text, textBox11.Text, maskedTextBox3.Text, textBox8.Text, foto);

            if (aluno.cadastrarAluno())
            {
                MessageBox.Show("Cadastro Realizado com sucesso!");

                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Atualizado com sucesso");
                }
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
        }

        private byte[] converterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            } }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|ALL files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
                try {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                } catch (Exception ex)
                {
                    MessageBox.Show("Nao foi possivel carregar a foto: " + ex.Message)
                     }
            dialog.Dispose();
        }



    } }



