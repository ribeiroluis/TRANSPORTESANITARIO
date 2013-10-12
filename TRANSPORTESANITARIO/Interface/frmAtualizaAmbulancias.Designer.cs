namespace TRANSPORTESANITARIO.Interface
{
    partial class frmAtualizaAmbulancias
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumeroAmbulancia = new System.Windows.Forms.ComboBox();
            this.tbambulanciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanciaEmpenhoDataSet = new TRANSPORTESANITARIO.BancoDados.AmbulanciaEmpenhoDataSet();
            this.tb_ambulanciaTableAdapter = new TRANSPORTESANITARIO.BancoDados.AmbulanciaEmpenhoDataSetTableAdapters.tb_ambulanciaTableAdapter();
            this.gbAmbulancia = new System.Windows.Forms.GroupBox();
            this.lbPlantao = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txMotivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSituacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txAnoAmbulancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txModeloAmbulancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFuncionarios = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbTecnicos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMotoristas = new System.Windows.Forms.ComboBox();
            this.btnFinalizarPlantao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbambulanciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanciaEmpenhoDataSet)).BeginInit();
            this.gbAmbulancia.SuspendLayout();
            this.gbFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº:";
            // 
            // cbNumeroAmbulancia
            // 
            this.cbNumeroAmbulancia.DataSource = this.tbambulanciaBindingSource;
            this.cbNumeroAmbulancia.DisplayMember = "NUMERO_AMBULANCIA";
            this.cbNumeroAmbulancia.FormattingEnabled = true;
            this.cbNumeroAmbulancia.Location = new System.Drawing.Point(6, 52);
            this.cbNumeroAmbulancia.Name = "cbNumeroAmbulancia";
            this.cbNumeroAmbulancia.Size = new System.Drawing.Size(58, 28);
            this.cbNumeroAmbulancia.TabIndex = 1;
            this.cbNumeroAmbulancia.ValueMember = "NUMERO_AMBULANCIA";
            this.cbNumeroAmbulancia.TextChanged += new System.EventHandler(this.cbNumeroAmbulancia_TextChanged);
            // 
            // tbambulanciaBindingSource
            // 
            this.tbambulanciaBindingSource.DataMember = "tb_ambulancia";
            this.tbambulanciaBindingSource.DataSource = this.ambulanciaEmpenhoDataSet;
            // 
            // ambulanciaEmpenhoDataSet
            // 
            this.ambulanciaEmpenhoDataSet.DataSetName = "AmbulanciaEmpenhoDataSet";
            this.ambulanciaEmpenhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ambulanciaTableAdapter
            // 
            this.tb_ambulanciaTableAdapter.ClearBeforeFill = true;
            // 
            // gbAmbulancia
            // 
            this.gbAmbulancia.Controls.Add(this.btnFinalizarPlantao);
            this.gbAmbulancia.Controls.Add(this.lbPlantao);
            this.gbAmbulancia.Controls.Add(this.btnRetornar);
            this.gbAmbulancia.Controls.Add(this.btnBaixar);
            this.gbAmbulancia.Controls.Add(this.btnSelecionar);
            this.gbAmbulancia.Controls.Add(this.txMotivo);
            this.gbAmbulancia.Controls.Add(this.label5);
            this.gbAmbulancia.Controls.Add(this.txSituacao);
            this.gbAmbulancia.Controls.Add(this.label4);
            this.gbAmbulancia.Controls.Add(this.txAnoAmbulancia);
            this.gbAmbulancia.Controls.Add(this.label3);
            this.gbAmbulancia.Controls.Add(this.txModeloAmbulancia);
            this.gbAmbulancia.Controls.Add(this.label2);
            this.gbAmbulancia.Controls.Add(this.cbNumeroAmbulancia);
            this.gbAmbulancia.Controls.Add(this.label1);
            this.gbAmbulancia.Location = new System.Drawing.Point(12, 12);
            this.gbAmbulancia.Name = "gbAmbulancia";
            this.gbAmbulancia.Size = new System.Drawing.Size(940, 153);
            this.gbAmbulancia.TabIndex = 2;
            this.gbAmbulancia.TabStop = false;
            this.gbAmbulancia.Text = "Ambulância";
            // 
            // lbPlantao
            // 
            this.lbPlantao.AutoSize = true;
            this.lbPlantao.Location = new System.Drawing.Point(370, 90);
            this.lbPlantao.Name = "lbPlantao";
            this.lbPlantao.Size = new System.Drawing.Size(67, 20);
            this.lbPlantao.TabIndex = 13;
            this.lbPlantao.Text = "Plantão:";
            this.lbPlantao.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Enabled = false;
            this.btnRetornar.Location = new System.Drawing.Point(226, 105);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(102, 28);
            this.btnRetornar.TabIndex = 12;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Enabled = false;
            this.btnBaixar.Location = new System.Drawing.Point(118, 105);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(102, 28);
            this.btnBaixar.TabIndex = 11;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.Location = new System.Drawing.Point(10, 105);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(102, 28);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txMotivo
            // 
            this.txMotivo.BackColor = System.Drawing.Color.White;
            this.txMotivo.Location = new System.Drawing.Point(471, 52);
            this.txMotivo.Name = "txMotivo";
            this.txMotivo.ReadOnly = true;
            this.txMotivo.Size = new System.Drawing.Size(463, 26);
            this.txMotivo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motivo:";
            // 
            // txSituacao
            // 
            this.txSituacao.BackColor = System.Drawing.Color.White;
            this.txSituacao.Location = new System.Drawing.Point(280, 52);
            this.txSituacao.Name = "txSituacao";
            this.txSituacao.ReadOnly = true;
            this.txSituacao.Size = new System.Drawing.Size(185, 26);
            this.txSituacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Situação:";
            // 
            // txAnoAmbulancia
            // 
            this.txAnoAmbulancia.BackColor = System.Drawing.Color.White;
            this.txAnoAmbulancia.Location = new System.Drawing.Point(215, 52);
            this.txAnoAmbulancia.Name = "txAnoAmbulancia";
            this.txAnoAmbulancia.ReadOnly = true;
            this.txAnoAmbulancia.Size = new System.Drawing.Size(59, 26);
            this.txAnoAmbulancia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano:";
            // 
            // txModeloAmbulancia
            // 
            this.txModeloAmbulancia.BackColor = System.Drawing.Color.White;
            this.txModeloAmbulancia.Location = new System.Drawing.Point(70, 52);
            this.txModeloAmbulancia.Name = "txModeloAmbulancia";
            this.txModeloAmbulancia.ReadOnly = true;
            this.txModeloAmbulancia.Size = new System.Drawing.Size(139, 26);
            this.txModeloAmbulancia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // gbFuncionarios
            // 
            this.gbFuncionarios.Controls.Add(this.btnSalvar);
            this.gbFuncionarios.Controls.Add(this.cbTecnicos);
            this.gbFuncionarios.Controls.Add(this.label7);
            this.gbFuncionarios.Controls.Add(this.label6);
            this.gbFuncionarios.Controls.Add(this.cbMotoristas);
            this.gbFuncionarios.Enabled = false;
            this.gbFuncionarios.Location = new System.Drawing.Point(12, 171);
            this.gbFuncionarios.Name = "gbFuncionarios";
            this.gbFuncionarios.Size = new System.Drawing.Size(940, 124);
            this.gbFuncionarios.TabIndex = 3;
            this.gbFuncionarios.TabStop = false;
            this.gbFuncionarios.Text = "Funcionários";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(471, 60);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbTecnicos
            // 
            this.cbTecnicos.DisplayMember = "MATRICULA_FUNCIONARIO";
            this.cbTecnicos.FormattingEnabled = true;
            this.cbTecnicos.Location = new System.Drawing.Point(238, 60);
            this.cbTecnicos.Name = "cbTecnicos";
            this.cbTecnicos.Size = new System.Drawing.Size(199, 28);
            this.cbTecnicos.TabIndex = 5;
            this.cbTecnicos.ValueMember = "MATRICULA_FUNCIONARIO";
            this.cbTecnicos.SelectedIndexChanged += new System.EventHandler(this.cbTecnicos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Técnico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Motorista:";
            // 
            // cbMotoristas
            // 
            this.cbMotoristas.DisplayMember = "MATRICULA_FUNCIONARIO";
            this.cbMotoristas.FormattingEnabled = true;
            this.cbMotoristas.Location = new System.Drawing.Point(10, 60);
            this.cbMotoristas.Name = "cbMotoristas";
            this.cbMotoristas.Size = new System.Drawing.Size(199, 28);
            this.cbMotoristas.TabIndex = 2;
            this.cbMotoristas.SelectedIndexChanged += new System.EventHandler(this.cbMotoristas_SelectedIndexChanged);
            // 
            // btnFinalizarPlantao
            // 
            this.btnFinalizarPlantao.Enabled = false;
            this.btnFinalizarPlantao.Location = new System.Drawing.Point(854, 119);
            this.btnFinalizarPlantao.Name = "btnFinalizarPlantao";
            this.btnFinalizarPlantao.Size = new System.Drawing.Size(80, 28);
            this.btnFinalizarPlantao.TabIndex = 14;
            this.btnFinalizarPlantao.Text = "Finalizar";
            this.btnFinalizarPlantao.UseVisualStyleBackColor = true;
            this.btnFinalizarPlantao.Click += new System.EventHandler(this.btnFinalizarPlantao_Click);
            // 
            // frmAtualizaAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.gbFuncionarios);
            this.Controls.Add(this.gbAmbulancia);
            this.Name = "frmAtualizaAmbulancias";
            this.Text = "frmAtualizaAmbulancias";
            this.Load += new System.EventHandler(this.frmAtualizaAmbulancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbambulanciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanciaEmpenhoDataSet)).EndInit();
            this.gbAmbulancia.ResumeLayout(false);
            this.gbAmbulancia.PerformLayout();
            this.gbFuncionarios.ResumeLayout(false);
            this.gbFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumeroAmbulancia;
        private BancoDados.AmbulanciaEmpenhoDataSet ambulanciaEmpenhoDataSet;
        private System.Windows.Forms.BindingSource tbambulanciaBindingSource;
        private BancoDados.AmbulanciaEmpenhoDataSetTableAdapters.tb_ambulanciaTableAdapter tb_ambulanciaTableAdapter;
        private System.Windows.Forms.GroupBox gbAmbulancia;
        private System.Windows.Forms.TextBox txMotivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAnoAmbulancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txModeloAmbulancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFuncionarios;
        private System.Windows.Forms.ComboBox cbTecnicos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMotoristas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label lbPlantao;
        private System.Windows.Forms.Button btnFinalizarPlantao;
    }
}