namespace TRANSPORTESANITARIO.Interface
{
    partial class frmFichadeAtendimento
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
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.txNumeroAtendimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUnidadeOrigem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txHorarionoLocal = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txSolicitante = new System.Windows.Forms.TextBox();
            this.txData = new System.Windows.Forms.TextBox();
            this.txHoraPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.AutoScroll = true;
            this.pnPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.pnPrincipal.Controls.Add(this.txNumeroAtendimento);
            this.pnPrincipal.Controls.Add(this.label7);
            this.pnPrincipal.Controls.Add(this.cbUnidadeOrigem);
            this.pnPrincipal.Controls.Add(this.label6);
            this.pnPrincipal.Controls.Add(this.txHorarionoLocal);
            this.pnPrincipal.Controls.Add(this.label5);
            this.pnPrincipal.Controls.Add(this.txTelefone);
            this.pnPrincipal.Controls.Add(this.label4);
            this.pnPrincipal.Controls.Add(this.txSolicitante);
            this.pnPrincipal.Controls.Add(this.txData);
            this.pnPrincipal.Controls.Add(this.txHoraPedido);
            this.pnPrincipal.Controls.Add(this.label3);
            this.pnPrincipal.Controls.Add(this.label8);
            this.pnPrincipal.Controls.Add(this.label2);
            this.pnPrincipal.Controls.Add(this.pictureBox1);
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1109, 661);
            this.pnPrincipal.TabIndex = 0;
            // 
            // txNumeroAtendimento
            // 
            this.txNumeroAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txNumeroAtendimento.Location = new System.Drawing.Point(961, 35);
            this.txNumeroAtendimento.Name = "txNumeroAtendimento";
            this.txNumeroAtendimento.ReadOnly = true;
            this.txNumeroAtendimento.Size = new System.Drawing.Size(136, 37);
            this.txNumeroAtendimento.TabIndex = 11;
            this.txNumeroAtendimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1000, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Empenho";
            // 
            // cbUnidadeOrigem
            // 
            this.cbUnidadeOrigem.FormattingEnabled = true;
            this.cbUnidadeOrigem.Location = new System.Drawing.Point(197, 166);
            this.cbUnidadeOrigem.Name = "cbUnidadeOrigem";
            this.cbUnidadeOrigem.Size = new System.Drawing.Size(391, 37);
            this.cbUnidadeOrigem.TabIndex = 9;
            this.cbUnidadeOrigem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUnidadeOrigem_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Unidade Origem:";
            // 
            // txHorarionoLocal
            // 
            this.txHorarionoLocal.Location = new System.Drawing.Point(200, 223);
            this.txHorarionoLocal.Mask = "00:00";
            this.txHorarionoLocal.Name = "txHorarionoLocal";
            this.txHorarionoLocal.Size = new System.Drawing.Size(95, 37);
            this.txHorarionoLocal.TabIndex = 4;
            this.txHorarionoLocal.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Horário no Local:";
            // 
            // txTelefone
            // 
            this.txTelefone.Location = new System.Drawing.Point(793, 166);
            this.txTelefone.Mask = "(99) 0000-0000";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(174, 37);
            this.txTelefone.TabIndex = 3;
            this.txTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefone_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone paciente:";
            // 
            // txSolicitante
            // 
            this.txSolicitante.BackColor = System.Drawing.Color.White;
            this.txSolicitante.Location = new System.Drawing.Point(682, 107);
            this.txSolicitante.Name = "txSolicitante";
            this.txSolicitante.Size = new System.Drawing.Size(359, 37);
            this.txSolicitante.TabIndex = 2;
            this.txSolicitante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txSolicitante_KeyDown);
            // 
            // txData
            // 
            this.txData.BackColor = System.Drawing.Color.White;
            this.txData.Location = new System.Drawing.Point(87, 107);
            this.txData.Name = "txData";
            this.txData.ReadOnly = true;
            this.txData.Size = new System.Drawing.Size(176, 37);
            this.txData.TabIndex = 1;
            // 
            // txHoraPedido
            // 
            this.txHoraPedido.BackColor = System.Drawing.Color.White;
            this.txHoraPedido.Location = new System.Drawing.Point(443, 107);
            this.txHoraPedido.Name = "txHoraPedido";
            this.txHoraPedido.ReadOnly = true;
            this.txHoraPedido.Size = new System.Drawing.Size(100, 37);
            this.txHoraPedido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solicitante:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora do Pedido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRANSPORTESANITARIO.Properties.Resources.suslogo;
            this.pictureBox1.Location = new System.Drawing.Point(39, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha de Atendimento - Transporte Sanitário\r\nAtendimento Hospitlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFichadeAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 661);
            this.Controls.Add(this.pnPrincipal);
            this.Name = "frmFichadeAtendimento";
            this.Text = "frmFichadeAtendimento";
            this.Load += new System.EventHandler(this.frmFichadeAtendimento_Load);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txHoraPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSolicitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txHorarionoLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUnidadeOrigem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNumeroAtendimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txData;
        private System.Windows.Forms.Label label8;
    }
}