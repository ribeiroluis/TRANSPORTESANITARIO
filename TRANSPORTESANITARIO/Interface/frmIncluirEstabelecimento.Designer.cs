using TRANSPORTESANITARIO.Controles;
namespace TRANSPORTESANITARIO.Interface
{
    partial class frmIncluirEstabelecimento
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
            this.txTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txPontoReferencia = new System.Windows.Forms.TextBox();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txTelefone2
            // 
            this.txTelefone2.Location = new System.Drawing.Point(795, 102);
            this.txTelefone2.Mask = "(99) 0000-0000";
            this.txTelefone2.Name = "txTelefone2";
            this.txTelefone2.ReadOnly = true;
            this.txTelefone2.Size = new System.Drawing.Size(178, 37);
            this.txTelefone2.TabIndex = 9;
            this.txTelefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefone2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tel:";
            // 
            // txTelefone1
            // 
            this.txTelefone1.Location = new System.Drawing.Point(546, 102);
            this.txTelefone1.Mask = "(99) 0000-0000";
            this.txTelefone1.Name = "txTelefone1";
            this.txTelefone1.ReadOnly = true;
            this.txTelefone1.Size = new System.Drawing.Size(178, 37);
            this.txTelefone1.TabIndex = 9;
            this.txTelefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefone1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel:";
            // 
            // txPontoReferencia
            // 
            this.txPontoReferencia.Location = new System.Drawing.Point(159, 147);
            this.txPontoReferencia.Multiline = true;
            this.txPontoReferencia.Name = "txPontoReferencia";
            this.txPontoReferencia.ReadOnly = true;
            this.txPontoReferencia.Size = new System.Drawing.Size(814, 86);
            this.txPontoReferencia.TabIndex = 7;
            // 
            // txComplemento
            // 
            this.txComplemento.Location = new System.Drawing.Point(300, 99);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.ReadOnly = true;
            this.txComplemento.Size = new System.Drawing.Size(184, 37);
            this.txComplemento.TabIndex = 7;
            this.txComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txComplemento_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ponto de ref:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Complemento:";
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(63, 99);
            this.txNumero.Name = "txNumero";
            this.txNumero.ReadOnly = true;
            this.txNumero.Size = new System.Drawing.Size(79, 37);
            this.txNumero.TabIndex = 5;
            this.txNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNumero_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº:";
            // 
            // txLogradouro
            // 
            this.txLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txLogradouro.Location = new System.Drawing.Point(148, 53);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.ReadOnly = true;
            this.txLogradouro.Size = new System.Drawing.Size(825, 37);
            this.txLogradouro.TabIndex = 3;
            this.txLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txLogradouro_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logradouro:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(92, 6);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(881, 37);
            this.txNome.TabIndex = 1;
            this.txNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::TRANSPORTESANITARIO.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(857, 255);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 38);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmIncluirEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 314);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txTelefone2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTelefone1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPontoReferencia);
            this.Controls.Add(this.txComplemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Name = "frmIncluirEstabelecimento";
            this.Text = "frmIncluirEstabelecimento";
            this.Load += new System.EventHandler(this.frmIncluirEstabelecimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txTelefone1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txTelefone2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txPontoReferencia;
        private System.Windows.Forms.Button btnSalvar;
    }
}