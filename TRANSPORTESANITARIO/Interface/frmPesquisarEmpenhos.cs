using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRANSPORTESANITARIO.BancoDados.EmpenhosDataSetTableAdapters;
using TRANSPORTESANITARIO.BancoDados.DataSetEstabelecimentoSaudeTableAdapters;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmPesquisarEmpenhos : frmModelo
    {
        int Tipo;
        viewAtendimentosHospitalaresTableAdapter bd;
        public int idAtendimentoSelecionado;
        /// <summary>
        /// Exibe os empenhos cadastrados para alteracao
        /// </summary>
        /// <param name="tipo">0 - atendimento hospitalar <=> 1 - atendimento domiciliar</param>
        public frmPesquisarEmpenhos(int tipo)
        {
            InitializeComponent();
            Tipo = tipo;
        }

        private void frmPesquisarEmpenhos_Load(object sender, EventArgs e)
        {
            if (Tipo == 0)
                PreencheHospitalar();
                
        }

        private void PreencheHospitalar()
        {
            try
            {
                bd = new viewAtendimentosHospitalaresTableAdapter();
                DataTable tabelaEmepnhos = bd.RetornaEmpenhosHospitalares();                
                tb_estabelicimento_saudeTableAdapter bdEstabelecimento = new tb_estabelicimento_saudeTableAdapter();
                int i = 0;
                dtgDados.Rows.Add(tabelaEmepnhos.Rows.Count);
                foreach (DataRow Linhas in tabelaEmepnhos.Rows)
                {                    
                    dtgDados[0, i].Value = Linhas[0].ToString();
                    dtgDados[1, i].Value = Linhas[1].ToString();
                    int x = (int)Linhas[2];
                    dtgDados[2, i].Value = bdEstabelecimento.RetornaEstabelecimentoPorId(x).ToString();
                    x = (int)Linhas[3];
                    dtgDados[3, i].Value = bdEstabelecimento.RetornaEstabelecimentoPorId(x).ToString();
                    dtgDados[4, i].Value = DateTime.Parse(Linhas[4].ToString()).ToShortDateString();
                    i++;
                }



            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void dtgDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Selecionar: " + dtgDados.CurrentRow.Cells[1].Value.ToString(), 
                "Atencao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                idAtendimentoSelecionado = int.Parse(dtgDados.CurrentRow.Cells[0].Value.ToString());
                this.Close();
            }
        }

        
    }
}
