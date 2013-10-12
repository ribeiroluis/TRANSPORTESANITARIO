using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRANSPORTESANITARIO.Controles;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmAtualizaAmbulancias : frmModelo
    {
        FuncionarioAmbulancia objFuncionarioAmbulancia;
        
        public frmAtualizaAmbulancias()
        {
            InitializeComponent();
            objFuncionarioAmbulancia = new FuncionarioAmbulancia();
        }

        private void frmAtualizaAmbulancias_Load(object sender, EventArgs e)
        {
            try
            {
                cbMotoristas.ResetText();
                cbTecnicos.ResetText();
                cbMotoristas.Items.Clear();
                cbTecnicos.Items.Clear();
                lbPlantao.Visible = false;
                btnFinalizarPlantao.Enabled = false;
                // TODO: This line of code loads data into the 'ambulanciaEmpenhoDataSet.tb_ambulancia' table. You can move, or remove it, as needed.
                this.tb_ambulanciaTableAdapter.Fill(this.ambulanciaEmpenhoDataSet.tb_ambulancia);
                this.cbNumeroAmbulancia.SelectedItem = 1;
                cbNumeroAmbulancia_TextChanged(sender, e);
                DataTable FuncMotorista = objFuncionarioAmbulancia.Motorista.RetornaFuncionariosporCargo("motorista");
                DataTable FuncEnfermagem = objFuncionarioAmbulancia.Enfermagem.RetornaFuncionariosporCargo("enferm");
                foreach (DataRow Linha in FuncMotorista.Rows)
                {
                    cbMotoristas.Items.Add(Linha["APELIDO_FUNCIONARIO"].ToString());        
                }                
                foreach (DataRow Linha in FuncEnfermagem.Rows)
                {
                    cbTecnicos.Items.Add(Linha["APELIDO_FUNCIONARIO"].ToString());
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
            
            

        }               

        private void cbNumeroAmbulancia_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var x = cbNumeroAmbulancia.SelectedValue;
                if (x != null)
                {
                    objFuncionarioAmbulancia._Ambulancia.Numero = (int)cbNumeroAmbulancia.SelectedValue;
                    objFuncionarioAmbulancia._Ambulancia.PesquisaAmbulancia();
                    txAnoAmbulancia.Text = objFuncionarioAmbulancia._Ambulancia.Ano.ToString();
                    txModeloAmbulancia.Text = objFuncionarioAmbulancia._Ambulancia.Modelo;
                    txMotivo.Text = string.Empty;
                    if (objFuncionarioAmbulancia._Ambulancia.Status == 0)
                    {
                        txSituacao.Text = "OCUPADA";
                        btnBaixar.Enabled = true;
                        btnSelecionar.Enabled = true;
                        btnRetornar.Enabled = false;
                    }
                    else if (objFuncionarioAmbulancia._Ambulancia.Status == 1)
                    {
                        txSituacao.Text = "DISPONIVEL";
                        btnBaixar.Enabled = true;
                        btnSelecionar.Enabled = true;
                        btnRetornar.Enabled = false;

                    }
                    else
                    {
                        txSituacao.Text = "BAIXADA";
                        txMotivo.Text = objFuncionarioAmbulancia._Ambulancia.MotivoBaixa;
                        btnRetornar.Enabled = true;
                        btnBaixar.Enabled = false;
                        btnSelecionar.Enabled = false;
                    }
                }

                if (objFuncionarioAmbulancia.PreencheFuncionarioAmbulancia())
                {
                    lbPlantao.Text = "Plantao iniciado:\n" +
                        "Motorista: " + objFuncionarioAmbulancia.Motorista.Apelido +
                        " - Técnico: " + objFuncionarioAmbulancia.Enfermagem.Apelido +
                        "\nInicio Plantão: " + objFuncionarioAmbulancia.Data;
                    lbPlantao.Visible = true;
                    btnFinalizarPlantao.Enabled = true;

                }
                else
                {
                    lbPlantao.Text = "Plantao não iniciado";
                    lbPlantao.Visible = true;
                }


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja baixar a ambulância: " + cbNumeroAmbulancia.SelectedText + "?", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    objFuncionarioAmbulancia._Ambulancia.Status = 3;
                    frmMotivoBaixa motivo = new frmMotivoBaixa();
                    motivo.ShowDialog();
                    objFuncionarioAmbulancia._Ambulancia.MotivoBaixa = motivo.MotivoBaixa;
                    if (objFuncionarioAmbulancia.BaixarAmbulancia())
                        MessageBox.Show("Baixada com sucesso");
                    else
                        MessageBox.Show("Erro ao atualizar o status da ambulancia");
                                        
                    frmAtualizaAmbulancias_Load(sender, e);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            gbFuncionarios.Enabled = true;
            gbAmbulancia.Enabled = false;


          
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja torrnar a ambulância disponível: " + cbNumeroAmbulancia.SelectedText + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    objFuncionarioAmbulancia._Ambulancia.Status = 1;
                    objFuncionarioAmbulancia._Ambulancia.MotivoBaixa = string.Empty;
                    if (objFuncionarioAmbulancia.RetornarAmbulancia())
                        MessageBox.Show("Retornada com sucesso");
                    else
                        MessageBox.Show("Erro ao atualizar o status da ambulancia");

                    frmAtualizaAmbulancias_Load(sender, e);
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                objFuncionarioAmbulancia.Data = DateTime.Now;
                objFuncionarioAmbulancia.HoraIncio = DateTime.Now;
                objFuncionarioAmbulancia.KM_Percorrido = 0;                
                if (objFuncionarioAmbulancia.PesquisaAmbulanciaDoDia())
                {
                    DialogResult resultado = MessageBox.Show("Já existe motorista e/ou técnico para esta ambulância.\n" +
                        "Clique em SIM para remanejar os funcionários\n" +
                    "Clique em NÃO para incluir novo plantão", "Atenção!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        objFuncionarioAmbulancia.AtualizaAmbulancia();
                    }
                    else
                    {
                        objFuncionarioAmbulancia.AtualizaAmbulancia(true);
                        objFuncionarioAmbulancia.InsereAmbulanciaDia();

                    }
                }
                else
                {
                    if (objFuncionarioAmbulancia.InsereAmbulanciaDia())
                        MessageBox.Show("Salvo com sucesso.");
                    else
                        MessageBox.Show("Erro ao salvar.");
                }
                frmAtualizaAmbulancias_Load(sender, e);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

            gbFuncionarios.Enabled = false;
            btnSalvar.Enabled = false;
            gbAmbulancia.Enabled = true;           
            
        }

        private void cbMotoristas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = cbMotoristas.Text;
            try
            {
                if (x != null)
                {
                    objFuncionarioAmbulancia.Motorista.Apelido = cbMotoristas.Text;
                    objFuncionarioAmbulancia.Motorista.PreencheFuncionarioPorApelido();
                    btnSalvar.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void cbTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = cbTecnicos.Text.ToString();
            try
            {
                if (x != null)
                {
                    objFuncionarioAmbulancia.Enfermagem.Apelido = cbTecnicos.Text;
                    objFuncionarioAmbulancia.Enfermagem.PreencheFuncionarioPorApelido();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnFinalizarPlantao_Click(object sender, EventArgs e)
        {
            try
            {
                objFuncionarioAmbulancia.AtualizaAmbulancia(true);
                frmAtualizaAmbulancias_Load(sender, e);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
             
    }
}
