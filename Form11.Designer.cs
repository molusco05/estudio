namespace estudio
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemanaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarTodas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarTodas);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtDiaSemana);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(29, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Turma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModalidade,
            this.professorTurma,
            this.diaSemanaTurma,
            this.horaTurma});
            this.dataGridView1.Location = new System.Drawing.Point(506, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // idModalidade
            // 
            this.idModalidade.HeaderText = "Modalidade";
            this.idModalidade.MinimumWidth = 6;
            this.idModalidade.Name = "idModalidade";
            this.idModalidade.Width = 125;
            // 
            // professorTurma
            // 
            this.professorTurma.HeaderText = "Professor";
            this.professorTurma.MinimumWidth = 6;
            this.professorTurma.Name = "professorTurma";
            this.professorTurma.Width = 125;
            // 
            // diaSemanaTurma
            // 
            this.diaSemanaTurma.HeaderText = "dia da semana";
            this.diaSemanaTurma.MinimumWidth = 6;
            this.diaSemanaTurma.Name = "diaSemanaTurma";
            this.diaSemanaTurma.Width = 125;
            // 
            // horaTurma
            // 
            this.horaTurma.HeaderText = "hora";
            this.horaTurma.MinimumWidth = 6;
            this.horaTurma.Name = "horaTurma";
            this.horaTurma.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "modalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "dia da semana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "hora";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(160, 150);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(308, 22);
            this.txtProfessor.TabIndex = 6;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(163, 210);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(308, 22);
            this.txtDiaSemana.TabIndex = 7;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(160, 265);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(311, 22);
            this.txtHora.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(43, 324);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 43);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "consultar uma";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultarTodas
            // 
            this.btnConsultarTodas.Location = new System.Drawing.Point(194, 324);
            this.btnConsultarTodas.Name = "btnConsultarTodas";
            this.btnConsultarTodas.Size = new System.Drawing.Size(122, 43);
            this.btnConsultarTodas.TabIndex = 12;
            this.btnConsultarTodas.Text = "consultar todas";
            this.btnConsultarTodas.UseVisualStyleBackColor = true;
            this.btnConsultarTodas.Click += new System.EventHandler(this.btnConsultarTodas_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 598);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemanaTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTurma;
        private System.Windows.Forms.Button btnConsultarTodas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
    }
}