namespace LogicaProgramacao
{
    partial class btnLimpar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.brnGravar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularIMc = new System.Windows.Forms.Button();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGravarCliente = new System.Windows.Forms.Button();
            this.btnCalcularFatorial = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExtrairPares = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnGravarRegistros = new System.Windows.Forms.Button();
            this.btnTestWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(53, 20);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // brnGravar
            // 
            this.brnGravar.Location = new System.Drawing.Point(16, 46);
            this.brnGravar.Name = "brnGravar";
            this.brnGravar.Size = new System.Drawing.Size(75, 23);
            this.brnGravar.TabIndex = 2;
            this.brnGravar.Text = "Gravar";
            this.brnGravar.UseVisualStyleBackColor = true;
            this.brnGravar.Click += new System.EventHandler(this.brnGravar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(52, 100);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(53, 125);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altura";
            // 
            // btnCalcularIMc
            // 
            this.btnCalcularIMc.Location = new System.Drawing.Point(68, 151);
            this.btnCalcularIMc.Name = "btnCalcularIMc";
            this.btnCalcularIMc.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularIMc.TabIndex = 7;
            this.btnCalcularIMc.Text = "CalcularIMC";
            this.btnCalcularIMc.UseVisualStyleBackColor = true;
            this.btnCalcularIMc.Click += new System.EventHandler(this.btnCalcularIMc_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "Normal",
            "Intermediário",
            "VIP"});
            this.cboTipoCliente.Location = new System.Drawing.Point(265, 20);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCliente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Cliente";
            // 
            // btnGravarCliente
            // 
            this.btnGravarCliente.Location = new System.Drawing.Point(199, 57);
            this.btnGravarCliente.Name = "btnGravarCliente";
            this.btnGravarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGravarCliente.TabIndex = 10;
            this.btnGravarCliente.Text = "Gravar";
            this.btnGravarCliente.UseVisualStyleBackColor = true;
            this.btnGravarCliente.Click += new System.EventHandler(this.btnGravarCliente_Click);
            // 
            // btnCalcularFatorial
            // 
            this.btnCalcularFatorial.Location = new System.Drawing.Point(199, 128);
            this.btnCalcularFatorial.Name = "btnCalcularFatorial";
            this.btnCalcularFatorial.Size = new System.Drawing.Size(170, 23);
            this.btnCalcularFatorial.TabIndex = 11;
            this.btnCalcularFatorial.Text = "Calcular Fatorial";
            this.btnCalcularFatorial.UseVisualStyleBackColor = true;
            this.btnCalcularFatorial.Click += new System.EventHandler(this.btnCalcularFatorial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fatorial de:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(259, 100);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(110, 20);
            this.txtN.TabIndex = 13;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(259, 188);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(110, 20);
            this.txtPares.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pares de:";
            // 
            // btnExtrairPares
            // 
            this.btnExtrairPares.Location = new System.Drawing.Point(199, 216);
            this.btnExtrairPares.Name = "btnExtrairPares";
            this.btnExtrairPares.Size = new System.Drawing.Size(170, 23);
            this.btnExtrairPares.TabIndex = 14;
            this.btnExtrairPares.Text = "Extrair Pares";
            this.btnExtrairPares.UseVisualStyleBackColor = true;
            this.btnExtrairPares.Click += new System.EventHandler(this.btnExtrairPares_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(16, 301);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 17;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnGravarRegistros
            // 
            this.btnGravarRegistros.Location = new System.Drawing.Point(113, 301);
            this.btnGravarRegistros.Name = "btnGravarRegistros";
            this.btnGravarRegistros.Size = new System.Drawing.Size(135, 23);
            this.btnGravarRegistros.TabIndex = 18;
            this.btnGravarRegistros.Text = "Gravar Registros";
            this.btnGravarRegistros.UseVisualStyleBackColor = true;
            this.btnGravarRegistros.Click += new System.EventHandler(this.btnGravarRegistros_Click);
            // 
            // btnTestWhile
            // 
            this.btnTestWhile.Location = new System.Drawing.Point(415, 216);
            this.btnTestWhile.Name = "btnTestWhile";
            this.btnTestWhile.Size = new System.Drawing.Size(170, 23);
            this.btnTestWhile.TabIndex = 19;
            this.btnTestWhile.Text = "Teste While";
            this.btnTestWhile.UseVisualStyleBackColor = true;
            this.btnTestWhile.Click += new System.EventHandler(this.btnTestWhile_Click);
            // 
            // btnLimpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 336);
            this.Controls.Add(this.btnTestWhile);
            this.Controls.Add(this.btnGravarRegistros);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExtrairPares);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcularFatorial);
            this.Controls.Add(this.btnGravarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.btnCalcularIMc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnGravar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Name = "btnLimpar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button brnGravar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularIMc;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGravarCliente;
        private System.Windows.Forms.Button btnCalcularFatorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExtrairPares;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnGravarRegistros;
        private System.Windows.Forms.Button btnTestWhile;
    }
}

