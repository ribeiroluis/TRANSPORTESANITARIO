namespace TRANSPORTESANITARIO.Interface
{
    partial class frmPacientesCadstrados
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
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkNovo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgDados.Location = new System.Drawing.Point(0, 0);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(963, 183);
            this.dtgDados.TabIndex = 0;
            this.dtgDados.DoubleClick += new System.EventHandler(this.dtgDados_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mais de um paciente localizado, de um duplo clique para selecionar ou";
            // 
            // linkNovo
            // 
            this.linkNovo.AutoSize = true;
            this.linkNovo.Location = new System.Drawing.Point(531, 198);
            this.linkNovo.Name = "linkNovo";
            this.linkNovo.Size = new System.Drawing.Size(214, 29);
            this.linkNovo.TabIndex = 2;
            this.linkNovo.TabStop = true;
            this.linkNovo.Text = "Clique aqui para novo";
            this.linkNovo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNovo_LinkClicked);
            // 
            // frmPacientesCadstrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 261);
            this.Controls.Add(this.linkNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPacientesCadstrados";
            this.Text = "frmPacientesCadstrados";
            this.Load += new System.EventHandler(this.frmPacientesCadstrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkNovo;
    }
}