
namespace AppDeCesta
{
    partial class frmCarro
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
            this.btnMinInicio = new System.Windows.Forms.Button();
            this.btnFecharInicio = new System.Windows.Forms.Button();
            this.btnInicioCarro = new System.Windows.Forms.Button();
            this.lstAgenda = new System.Windows.Forms.ListBox();
            this.cmbPg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lstAgenda1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMinInicio
            // 
            this.btnMinInicio.BackColor = System.Drawing.Color.White;
            this.btnMinInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinInicio.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinInicio.ForeColor = System.Drawing.Color.Sienna;
            this.btnMinInicio.Location = new System.Drawing.Point(950, 12);
            this.btnMinInicio.Name = "btnMinInicio";
            this.btnMinInicio.Size = new System.Drawing.Size(125, 27);
            this.btnMinInicio.TabIndex = 7;
            this.btnMinInicio.Text = "Minimizar";
            this.btnMinInicio.UseVisualStyleBackColor = false;
            this.btnMinInicio.Click += new System.EventHandler(this.btnMinInicio_Click);
            // 
            // btnFecharInicio
            // 
            this.btnFecharInicio.BackColor = System.Drawing.Color.White;
            this.btnFecharInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharInicio.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharInicio.ForeColor = System.Drawing.Color.Sienna;
            this.btnFecharInicio.Location = new System.Drawing.Point(1080, 12);
            this.btnFecharInicio.Name = "btnFecharInicio";
            this.btnFecharInicio.Size = new System.Drawing.Size(125, 27);
            this.btnFecharInicio.TabIndex = 6;
            this.btnFecharInicio.Text = "Fechar";
            this.btnFecharInicio.UseVisualStyleBackColor = false;
            this.btnFecharInicio.Click += new System.EventHandler(this.btnFecharInicio_Click);
            // 
            // btnInicioCarro
            // 
            this.btnInicioCarro.AutoSize = true;
            this.btnInicioCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioCarro.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioCarro.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInicioCarro.Location = new System.Drawing.Point(12, 617);
            this.btnInicioCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioCarro.Name = "btnInicioCarro";
            this.btnInicioCarro.Size = new System.Drawing.Size(153, 50);
            this.btnInicioCarro.TabIndex = 100;
            this.btnInicioCarro.Text = "Tela inicial";
            this.btnInicioCarro.UseVisualStyleBackColor = true;
            this.btnInicioCarro.Click += new System.EventHandler(this.btnInicioCarro_Click);
            // 
            // lstAgenda
            // 
            this.lstAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAgenda.FormattingEnabled = true;
            this.lstAgenda.ItemHeight = 20;
            this.lstAgenda.Location = new System.Drawing.Point(676, 70);
            this.lstAgenda.Name = "lstAgenda";
            this.lstAgenda.Size = new System.Drawing.Size(529, 384);
            this.lstAgenda.TabIndex = 103;
            // 
            // cmbPg
            // 
            this.cmbPg.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPg.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbPg.FormattingEnabled = true;
            this.cmbPg.Items.AddRange(new object[] {
            "Cartão de crédito",
            "Cartão de débito",
            "Pix",
            "Dinheiro na entrega"});
            this.cmbPg.Location = new System.Drawing.Point(18, 437);
            this.cmbPg.Name = "cmbPg";
            this.cmbPg.Size = new System.Drawing.Size(299, 31);
            this.cmbPg.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(13, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 105;
            this.label1.Text = "Forma de pagamento";
            // 
            // btnComprar
            // 
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnComprar.Location = new System.Drawing.Point(676, 607);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(529, 60);
            this.btnComprar.TabIndex = 106;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLimpar.Location = new System.Drawing.Point(676, 523);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(529, 64);
            this.btnLimpar.TabIndex = 108;
            this.btnLimpar.Text = "Limpar carrinho";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 109;
            this.label2.Text = "Endereço:";
            // 
            // txbEnd
            // 
            this.txbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnd.Location = new System.Drawing.Point(18, 214);
            this.txbEnd.Name = "txbEnd";
            this.txbEnd.Size = new System.Drawing.Size(293, 36);
            this.txbEnd.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(13, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 111;
            this.label3.Text = "Bairro:";
            // 
            // txbBairro
            // 
            this.txbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBairro.Location = new System.Drawing.Point(18, 330);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(293, 36);
            this.txbBairro.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 28);
            this.label4.TabIndex = 113;
            this.label4.Text = "Nome do destinatário";
            // 
            // txbDest
            // 
            this.txbDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDest.Location = new System.Drawing.Point(18, 106);
            this.txbDest.Name = "txbDest";
            this.txbDest.Size = new System.Drawing.Size(293, 36);
            this.txbDest.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(312, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 28);
            this.label5.TabIndex = 115;
            this.label5.Text = "N°";
            // 
            // txbNum
            // 
            this.txbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNum.Location = new System.Drawing.Point(317, 214);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 36);
            this.txbNum.TabIndex = 116;
            // 
            // lstAgenda1
            // 
            this.lstAgenda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAgenda1.FormattingEnabled = true;
            this.lstAgenda1.ItemHeight = 38;
            this.lstAgenda1.Location = new System.Drawing.Point(676, 461);
            this.lstAgenda1.Name = "lstAgenda1";
            this.lstAgenda1.Size = new System.Drawing.Size(529, 42);
            this.lstAgenda1.TabIndex = 117;
            // 
            // frmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 678);
            this.Controls.Add(this.lstAgenda1);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPg);
            this.Controls.Add(this.lstAgenda);
            this.Controls.Add(this.btnInicioCarro);
            this.Controls.Add(this.btnMinInicio);
            this.Controls.Add(this.btnFecharInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.frmCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinInicio;
        private System.Windows.Forms.Button btnFecharInicio;
        private System.Windows.Forms.Button btnInicioCarro;
        private System.Windows.Forms.ListBox lstAgenda;
        private System.Windows.Forms.ComboBox cmbPg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.ListBox lstAgenda1;
    }
}