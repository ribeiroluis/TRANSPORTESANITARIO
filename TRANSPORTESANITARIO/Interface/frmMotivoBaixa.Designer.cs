namespace TRANSPORTESANITARIO.Interface
{
    partial class frmMotivoBaixa
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
            this.txMotivo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txMotivo
            // 
            this.txMotivo.Location = new System.Drawing.Point(12, 12);
            this.txMotivo.Name = "txMotivo";
            this.txMotivo.Size = new System.Drawing.Size(609, 26);
            this.txMotivo.TabIndex = 0;
            this.txMotivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txMotivo_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::TRANSPORTESANITARIO.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(516, 44);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 34);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmMotivoBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 82);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txMotivo);
            this.Name = "frmMotivoBaixa";
            this.Text = "frmMotivoBaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMotivo;
        private System.Windows.Forms.Button btnSalvar;
    }
}