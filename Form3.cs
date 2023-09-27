﻿using System;
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

            if(e.KeyChar == 13)
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
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox2.Text, textBox3.Text, textBox9.Text, textBox4.Text, textBox10.Text, maskedTextBox2.Text, textBox7.Text, textBox11.Text, maskedTextBox3.Text, textBox8.Text);

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

    }
}
