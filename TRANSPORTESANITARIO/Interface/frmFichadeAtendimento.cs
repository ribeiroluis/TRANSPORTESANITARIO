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
    public partial class frmFichadeAtendimento : frmModelo
    {
        int Matricula;
        Atendimento objAtendimento;        

        public frmFichadeAtendimento(int matricula)
        {
            InitializeComponent();
            objAtendimento = new Atendimento();
            objAtendimento.FuncionarioResponsavel.Matricula = matricula;
            objAtendimento.FuncionarioResponsavel.RetornaProfissionalResponsavelAtendimento();
            Matricula = matricula;
        }

        private void txTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objAtendimento._Paciente.Telefone1 = txTelefone.Text;
                this.ActiveControl = txHistorico;
            }
        }

        private void txSolicitante_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ValidaTexto(txSolicitante.Text.ToUpper()))
                {
                    objAtendimento.Solicitante = txSolicitante.Text.ToUpper();
                    this.ActiveControl = cbUnidadeOrigem;
                    txSolicitante.Text = objAtendimento.Solicitante;
                }
                else
                    txSolicitante.Text = string.Empty;
            }
        }

        private void frmFichadeAtendimento_Load(object sender, EventArgs e)
        {            

            CarregarEstabelecimentos();
            btnSalvar.Enabled = true;


            objAtendimento.HoraAtendimento = DateTime.Parse(DateTime.Now.ToShortTimeString());
            txHoraPedido.Text = objAtendimento.HoraAtendimento.ToShortTimeString();


            objAtendimento.DataAtendimento = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            objAtendimento.DataconsultaExame = objAtendimento.DataAtendimento;

            objAtendimento.HoraAtendimento = DateTime.Parse(txHoraPedido.Text);

            txData.Text = objAtendimento.DataAtendimento.ToShortDateString();

            txNumeroAtendimento.Text = objAtendimento.IdAtendimento.ToString().PadLeft(5, '0');
            lbProfResponsvel.Text = objAtendimento.FuncionarioResponsavel.Apelido;

            this.ActiveControl = txSolicitante;

            DataTable tabelaPacientes = objAtendimento._Paciente.RetornaPacientesCadastrados();
            foreach (DataRow Linha in tabelaPacientes.Rows)
            {
                if (!Linha["NOME_PACIENTE"].ToString().Equals("PACIENTE NAO CADASTRADO"))
                    txPaciente.AutoCompleteCustomSource.Add(Linha["NOME_PACIENTE"].ToString());
            }

            this.WindowState = FormWindowState.Maximized;
            
        }

        private void cbUnidadeOrigem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cbUnidadeOrigem.Text.Equals("INCLUIR NOVO"))
                    {
                        frmIncluirEstabelecimento incluir = new frmIncluirEstabelecimento();
                        incluir.ShowDialog();
                        int id = incluir.IdEstabelecimento;
                        this.ActiveControl = cbUnidadeDestino;
                        CarregarEstabelecimentos();
                        cbUnidadeOrigem.SelectedValue = id;
                    }
                    else
                    {
                        objAtendimento._EstabelecimentoSaudeOrigem.NomeEstabelecimento = cbUnidadeOrigem.Text;
                        objAtendimento._EstabelecimentoSaudeOrigem.RetornaEstabelecimento();
                        this.ActiveControl = cbUnidadeDestino;
                    }
                    lbDadosOrigem.Visible = true;
                    string _end = "Endereço: " + objAtendimento._EstabelecimentoSaudeOrigem.Cep.Logradouro + ", " +
                        objAtendimento._EstabelecimentoSaudeOrigem.Numero + ", " + objAtendimento._EstabelecimentoSaudeOrigem.Complemento + " - " +
                        objAtendimento._EstabelecimentoSaudeOrigem.Cep.Cidade + "\nTelefones: " + objAtendimento._EstabelecimentoSaudeOrigem.Telefone1 + " - " +
                        objAtendimento._EstabelecimentoSaudeOrigem.Telefone2 + "\n" + objAtendimento._EstabelecimentoSaudeOrigem.PontoReferencia;
                    lbDadosOrigem.Text = _end;

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }
        
        private void CarregarEstabelecimentos()
        {
            // TODO: This line of code loads data into the 'dataSetEstabelecimentoSaude.tb_estabelicimento_saude' table. You can move, or remove it, as needed.
            this.tb_estabelicimento_saudeTableAdapter.Fill(this.dataSetEstabelecimentoSaude.tb_estabelicimento_saude);
            cbUnidadeOrigem.SelectedValue = 2;
            cbUnidadeDestino.SelectedValue = 2;            
        }

        private void txHorarionoLocal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimeSpan hora = TimeSpan.Parse(txHorarionoLocal.Text);
                    if (txHorarionoLocal.Text.Length < 5)
                        MessageBox.Show("Hora inválida");
                    else
                    {
                        objAtendimento.HoraConsultaExame = DateTime.Parse(txHorarionoLocal.Text);
                        this.ActiveControl = txPaciente;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message + "\nDigite uma hora válida!");
            }
        }

        private void cbUnidadeDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cbUnidadeDestino.Text.Equals("INCLUIR NOVO"))
                    {
                        frmIncluirEstabelecimento incluir = new frmIncluirEstabelecimento();
                        incluir.ShowDialog();
                        int id = incluir.IdEstabelecimento;
                        this.ActiveControl = txHorarionoLocal;
                        CarregarEstabelecimentos();
                        cbUnidadeDestino.SelectedValue = id;
                    }
                    else
                    {
                        objAtendimento._EstabelecimentoSaudeDestino.NomeEstabelecimento = cbUnidadeDestino.Text;
                        objAtendimento._EstabelecimentoSaudeDestino.RetornaEstabelecimento();
                        this.ActiveControl = txHorarionoLocal;
                    }

                    lbDadosDestino.Visible = true;
                    string _end = "Endereço: " + objAtendimento._EstabelecimentoSaudeDestino.Cep.Logradouro + ", " +
                        objAtendimento._EstabelecimentoSaudeDestino.Numero + ", " + objAtendimento._EstabelecimentoSaudeDestino.Complemento + " - " +
                        objAtendimento._EstabelecimentoSaudeDestino.Cep.Cidade + "\nTelefones: " + objAtendimento._EstabelecimentoSaudeDestino.Telefone1 + " - " +
                        objAtendimento._EstabelecimentoSaudeDestino.Telefone2 + "\n" + objAtendimento._EstabelecimentoSaudeDestino.PontoReferencia;
                    lbDadosDestino.Text = _end;

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private bool ValidaTexto(string texto)
        {
           foreach (char caractere in texto)
            {
                if (caractere != 32)
                {
                    if (caractere < 65 || caractere > 90)
                    {
                        MessageBox.Show("Não utilize acentuação ou caracteres especiais:\n^`:'çáéí...");                        
                        return false;
                    }
                }
            }
            return true;
        }

        private void txPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (ValidaTexto(txPaciente.Text.ToUpper()))
                    {
                        DataTable tbPaciente = objAtendimento._Paciente.VerificaNomeCadastrado(txPaciente.Text.ToUpper());

                        if (tbPaciente != null)
                        {
                            if (tbPaciente.Rows.Count == 1)
                            {
                                txPaciente.Text = objAtendimento._Paciente.NomePaciente;
                                txTelefone.Text = objAtendimento._Paciente.Telefone1;
                                txIdade.Text = objAtendimento._Paciente.Idade.ToString();
                                if (objAtendimento._Paciente.Sexo == 'F')
                                    radioFeminino.Checked = true;
                                else
                                    radioMasculino.Checked = true;
                                txHistorico.Text = objAtendimento._Paciente.Historico;
                                this.ActiveControl = txPASistolica;
                                objAtendimento._Paciente.ExistePaciente = true;
                            }
                            else if (tbPaciente.Rows.Count > 1)
                            {
                                frmPacientesCadstrados pac = new frmPacientesCadstrados(tbPaciente);
                                pac.ShowDialog();
                                if (pac.ID == 0)
                                {
                                    objAtendimento._Paciente.NomePaciente = txPaciente.Text.ToUpper();
                                    this.ActiveControl = txIdade;
                                }
                                else
                                {
                                    foreach (DataRow linha in tbPaciente.Rows)
                                    {
                                        if ((int)linha["idPACIENTE"] == pac.ID)
                                        {                                            
                                            objAtendimento._Paciente.IDPaciente = pac.ID;
                                            objAtendimento._Paciente.PreenchePacientePorID();
                                            txPaciente.Text = objAtendimento._Paciente.NomePaciente;
                                            txTelefone.Text = objAtendimento._Paciente.Telefone1;
                                            txIdade.Text = objAtendimento._Paciente.Idade.ToString();
                                            if (objAtendimento._Paciente.Sexo == 'F')
                                                radioFeminino.Checked = true;
                                            else
                                                radioMasculino.Checked = true;
                                            txHistorico.Text = objAtendimento._Paciente.Historico;
                                            objAtendimento._Paciente.ExistePaciente = true;
                                            this.ActiveControl = txPASistolica;
                                            break;
                                        }
                                    }
                                }
                            }
 
                        }                       
                        else
                        {
                            objAtendimento._Paciente.NomePaciente = txPaciente.Text.ToUpper();
                            txPaciente.Text = txPaciente.Text.ToUpper();
                            this.ActiveControl = txIdade;
                            objAtendimento._Paciente.ExistePaciente = false;
                            objAtendimento._Paciente.IDPaciente = 0;

                        }
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txPADiastolica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txPADiastolica.Text.Equals(""))
                {
                    objAtendimento.PADiastolica = int.Parse(txPADiastolica.Text);
                    this.ActiveControl = txFrequenciaCardiaca;
                }
                else
                    this.ActiveControl = txFrequenciaCardiaca;
            }
        }

        private void txPASistolica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txPASistolica.Text.Equals(""))
                {
                    objAtendimento.PASistolica = int.Parse(txPASistolica.Text);
                    this.ActiveControl = txPADiastolica;
                }
                else
                    this.ActiveControl = txPADiastolica;
            }
        }

        private void txFrequenciaCardiaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txFrequenciaCardiaca.Text.Equals(""))
                {
                    objAtendimento.FrequenciaCardiaca = int.Parse(txFrequenciaCardiaca.Text);
                    this.ActiveControl = txFrequenciaRespiratoria;
                }
                else
                    this.ActiveControl = txFrequenciaRespiratoria;
            }
        }

        private void txFrequenciaRespiratoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txFrequenciaRespiratoria.Text.Equals(""))
                {
                    objAtendimento.FrequenciaRespiratoria = int.Parse(txFrequenciaRespiratoria.Text);
                    this.ActiveControl = txTemperatura;
                }
                else
                    this.ActiveControl = txTemperatura;
            }
        }

        private void txTemperatura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txTemperatura.Text.Equals(""))
                {
                    objAtendimento.Temperatura = int.Parse(txTemperatura.Text);
                    this.ActiveControl = txSaturacao;
                }
                else
                    this.ActiveControl = txSaturacao;
            }
        }

        private void txSaturacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txSaturacao.Text.Equals(""))
                {
                    objAtendimento.Saturacao = int.Parse(txSaturacao.Text);
                    this.ActiveControl = txObservacao;
                }
                
            }
        }

        private void txIdade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txIdade.Text.Equals(""))
                {
                    objAtendimento._Paciente.Idade = int.Parse(txIdade.Text);
                    this.ActiveControl = radioFeminino;
                }

            }
        }

        private void radioFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFeminino.Checked)
                objAtendimento._Paciente.Sexo = 'F';
            else
                objAtendimento._Paciente.Sexo = 'M';
            this.ActiveControl = txTelefone;
        }

        private void txHistorico_Leave(object sender, EventArgs e)
        {
            string x = txHistorico.Text.ToUpper();
            objAtendimento._Paciente.Historico = x;
            txHistorico.Text = x;
            this.ActiveControl = txPASistolica;
        }

        private void txObservacao_Leave(object sender, EventArgs e)
        {
            string x = txObservacao.Text.ToUpper();
            objAtendimento.Observacao = x;
            txObservacao.Text = x;
            this.ActiveControl = btnSalvar;
            if (!btnSalvar.Enabled)
                this.ActiveControl = btnAlterar;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado;
                if (objAtendimento.PesquisaAtendimentoExistente())
                {
                    resultado = MessageBox.Show("Incluir o retorno deste empenho?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        objAtendimento.IdAtendimento = objAtendimento.RetornaULtimoEmpenho() + 1;
                        int origem = objAtendimento._EstabelecimentoSaudeDestino.IdEstabelecimentoSaude;
                        int destino = objAtendimento._EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude;
                        objAtendimento._EstabelecimentoSaudeDestino.IdEstabelecimentoSaude = destino;
                        objAtendimento._EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude = origem;
                        objAtendimento.StatusAtendimento = false;
                        objAtendimento.HoraConsultaExame = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                        objAtendimento.DataAtendimento = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        objAtendimento.DataconsultaExame = DateTime.Parse(txData.Text);
                        objAtendimento.HoraAtendimento = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                        
                        bool resul = objAtendimento.IncluirAtendimento();
                        if (resul)
                        {
                            MessageBox.Show("Salvo com sucesso");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Erro ao gravar.");
                    }

                }
                else
                {
                    resultado = MessageBox.Show("Salvar o empenho e sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool res = objAtendimento.IncluirAtendimento();
                        if (res)
                        {
                            MessageBox.Show("Salvo com sucesso");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Erro ao gravar.");
                    }
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void txObservacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txObservacao_Leave(sender, e);
            }
        }

        private void txHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txHistorico_Leave(sender, e);
            }
        }

        private void dtDataConsulta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                objAtendimento.DataconsultaExame = DateTime.Parse(dtDataConsulta.Text);
                this.ActiveControl = txPaciente;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                frmPesquisarEmpenhos emp = new frmPesquisarEmpenhos(0);
                emp.ShowDialog();
                objAtendimento.IdAtendimento = emp.idAtendimentoSelecionado;
                PreencheCamposAtendimento();
                lbResponsavelAteracao.Visible = true;
                lbResponsavelAlteracaoLB.Visible = true;
                objAtendimento.FuncionarioResponsavel.Matricula = Matricula;
                objAtendimento.FuncionarioResponsavel.RetornaProfissionalResponsavelAtendimento();
                lbResponsavelAteracao.Text = objAtendimento.FuncionarioResponsavel.Apelido;
                btnAlterar.Enabled = true;
                this.ActiveControl = txSolicitante;
                

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message + "\nNenhum empenho selecionado");
            }
            
            
        }

        private void PreencheCamposAtendimento()
        {
            objAtendimento.PesquisaAtendimento();

            Object send = new object();  
            KeyEventArgs key = new KeyEventArgs(Keys.Enter);

            txData.Text = objAtendimento.DataAtendimento.ToShortDateString();
            txFrequenciaCardiaca.Text = objAtendimento.FrequenciaCardiaca.ToString();
            txFrequenciaRespiratoria.Text = objAtendimento.FrequenciaRespiratoria.ToString();
            txHistorico.Text = objAtendimento._Paciente.Historico;
            txHoraPedido.Text = objAtendimento.HoraAtendimento.ToShortTimeString();
            cbUnidadeOrigem.SelectedValue = objAtendimento._EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude;
            cbUnidadeOrigem_KeyDown(send, key);
            cbUnidadeDestino.SelectedValue = objAtendimento._EstabelecimentoSaudeDestino.IdEstabelecimentoSaude;
            cbUnidadeDestino_KeyDown(send, key);
            txHorarionoLocal.Text = objAtendimento.HoraConsultaExame.ToShortTimeString();
            dtDataConsulta.Value = objAtendimento.DataconsultaExame;
            txIdade.Text = objAtendimento._Paciente.Idade.ToString();
            txNumeroAtendimento.Text = objAtendimento.IdAtendimento.ToString().PadLeft(5, '0');
            txObservacao.Text = objAtendimento.Observacao;
            txPaciente.Text = objAtendimento._Paciente.NomePaciente;
            txPADiastolica.Text = objAtendimento.PADiastolica.ToString();
            txPASistolica.Text = objAtendimento.PASistolica.ToString();
            txSaturacao.Text = objAtendimento.Saturacao.ToString();
            txSolicitante.Text = objAtendimento.Solicitante;
            txTelefone.Text = objAtendimento._Paciente.Telefone1;
            txTemperatura.Text = objAtendimento.Temperatura.ToString();
            lbProfResponsvel.Text = objAtendimento.FuncionarioResponsavel.Apelido;

            if (objAtendimento.StatusAtendimento)
                lbStatusAtendimento.Text = "Atendido - Motorista: " + objAtendimento._Empenho._FuncionarioAmbulancia.Motorista.Apelido
                    + "Hora: " + objAtendimento._Empenho.HoraInicio;
            else
                lbStatusAtendimento.Text = "Aguardando atendimento";


            if (objAtendimento._Paciente.Sexo.Equals('F'))
                radioFeminino.Checked = true;
            else
                radioMasculino.Checked = true; 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Você está prestes a alterar os dados do empenho.\nDeseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    objAtendimento.Observacao += " - Alterado por: " + lbResponsavelAteracao.Text + ", em: " + DateTime.Now.ToString() + "\n";
                    btnAlterar.Enabled = false;
                    if (objAtendimento.AlteraAtendimento())
                        MessageBox.Show("Alterado com sucesso");
                    else
                        MessageBox.Show("Erro ao alterar");
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                txNumeroAtendimento.Text = string.Empty;
                txData.Text = string.Empty;
                txFrequenciaCardiaca.Text = string.Empty;
                txFrequenciaRespiratoria.Text = string.Empty;
                txHistorico.Text = string.Empty;
                txHoraPedido.Text = string.Empty;
                txHorarionoLocal.Text = string.Empty;
                dtDataConsulta.Value = DateTime.Now;
                txIdade.Text = string.Empty;
                txNumeroAtendimento.Text = string.Empty;
                txObservacao.Text = string.Empty;
                txPaciente.Text = string.Empty;
                txPADiastolica.Text = string.Empty;
                txPASistolica.Text = string.Empty;
                txSaturacao.Text = string.Empty;
                txSolicitante.Text = string.Empty;
                txTelefone.Text = string.Empty;
                txTemperatura.Text = string.Empty;
                lbProfResponsvel.Text = string.Empty;
                lbStatusAtendimento.Text = string.Empty;
                lbDadosDestino.Text = string.Empty;
                lbDadosOrigem.Text = string.Empty;
                objAtendimento = new Atendimento();
                objAtendimento.FuncionarioResponsavel.Matricula = Matricula;
                objAtendimento.FuncionarioResponsavel.RetornaProfissionalResponsavelAtendimento();
                lbResponsavelAlteracaoLB.Visible = false;
                lbResponsavelAteracao.Visible = false;
                frmFichadeAtendimento_Load(sender, e);

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

            
        }

    }
}
