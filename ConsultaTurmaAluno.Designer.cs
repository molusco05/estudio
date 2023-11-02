
namespace estudio
{
    partial class ConsultaTurmaAluno
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblqntd = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.lblqntd);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtQntd);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(49, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(799, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(8, 268);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(101, 16);
            this.lblDia.TabIndex = 10;
            this.lblDia.Text = "Dia da Semana";
            // 
            // lblqntd
            // 
            this.lblqntd.AutoSize = true;
            this.lblqntd.Location = new System.Drawing.Point(8, 209);
            this.lblqntd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqntd.Name = "lblqntd";
            this.lblqntd.Size = new System.Drawing.Size(98, 16);
            this.lblqntd.TabIndex = 9;
            this.lblqntd.Text = "Qntd de Alunos";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(40, 143);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(37, 16);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(123, 265);
            this.txtDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(259, 22);
            this.txtDia.TabIndex = 7;
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(123, 206);
            this.txtQntd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(259, 22);
            this.txtQntd.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(109, 143);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(259, 22);
            this.txtHora.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAluno});
            this.dataGridView1.Location = new System.Drawing.Point(444, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 347);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome dos alunos";
            this.nomeAluno.MinimumWidth = 6;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Width = 125;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(36, 84);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 16);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Turma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 336);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(368, 34);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ConsultaTurmaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 497);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultaTurmaAluno";
            this.Text = "ConsultaTurmaAluno";
            this.Load += new System.EventHandler(this.ConsultaTurmaAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblqntd;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.TextBox txtHora;
    }
}