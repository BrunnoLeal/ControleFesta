namespace ControleFesta
{
    partial class Principal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.LinkLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txbAno = new System.Windows.Forms.NumericUpDown();
            this.lblapv = new System.Windows.Forms.Label();
            this.lblcpt = new System.Windows.Forms.Label();
            this.lblmidd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(420, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Controle de entrada ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Lime;
            this.btnVerificar.Location = new System.Drawing.Point(399, 238);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(132, 42);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::ControleFesta.Properties.Resources.lapis_e_regua_cruzados;
            this.pibIcone.Location = new System.Drawing.Point(21, 35);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(298, 343);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 0;
            this.pibIcone.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpar.Location = new System.Drawing.Point(399, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(132, 38);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "limpar ";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.LinkColor = System.Drawing.Color.Red;
            this.lblSair.Location = new System.Drawing.Point(768, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(20, 20);
            this.lblSair.TabIndex = 6;
            this.lblSair.TabStop = true;
            this.lblSair.Text = "X";
            this.lblSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSair_LinkClicked);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(396, 114);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(396, 159);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 8;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.Click += new System.EventHandler(this.lblSobrenome_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(463, 111);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 9;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(463, 152);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txbSobrenome.TabIndex = 10;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(396, 194);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(54, 13);
            this.lblIdade.TabIndex = 11;
            this.lblIdade.Text = "AnoNasc.";
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(463, 192);
            this.txbAno.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.txbAno.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(100, 20);
            this.txbAno.TabIndex = 12;
            this.txbAno.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // lblapv
            // 
            this.lblapv.AutoSize = true;
            this.lblapv.Location = new System.Drawing.Point(638, 157);
            this.lblapv.Name = "lblapv";
            this.lblapv.Size = new System.Drawing.Size(0, 13);
            this.lblapv.TabIndex = 13;
            // 
            // lblcpt
            // 
            this.lblcpt.AutoSize = true;
            this.lblcpt.Location = new System.Drawing.Point(677, 172);
            this.lblcpt.Name = "lblcpt";
            this.lblcpt.Size = new System.Drawing.Size(0, 13);
            this.lblcpt.TabIndex = 14;
            // 
            // lblmidd
            // 
            this.lblmidd.AutoSize = true;
            this.lblmidd.Location = new System.Drawing.Point(700, 212);
            this.lblmidd.Name = "lblmidd";
            this.lblmidd.Size = new System.Drawing.Size(0, 13);
            this.lblmidd.TabIndex = 15;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lblmidd);
            this.Controls.Add(this.lblcpt);
            this.Controls.Add(this.lblapv);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibIcone);
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.LinkLabel lblSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.NumericUpDown txbAno;
        private System.Windows.Forms.Label lblapv;
        private System.Windows.Forms.Label lblcpt;
        private System.Windows.Forms.Label lblmidd;
    }
}