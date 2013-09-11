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
    public partial class frmFichaAtendimento : frmModelo
    {
        string NomeSolicitante;
        Atendimento atendimento;
        Paciente paciente;

        public frmFichaAtendimento(string nome)
        {
            InitializeComponent();
            NomeSolicitante = nome;            
        }

        private void frmFichaAtendimento_Load(object sender, EventArgs e)
        {
            atendimento = new Atendimento();
            paciente = new Paciente();
            txHora.Text = DateTime.Now.ToShortTimeString();
            txSolicitante.Text = NomeSolicitante;
            txDataFicha.Text = DateTime.Now.ToShortDateString();
            txNumeroEmpenho.Text = atendimento.RetornaULtimoEmpenho().ToString().PadLeft(5, '0');
            List<Paciente> ListaPacientesCadastrados = paciente.RetornaListaPacientesCadastrados();
            txNomePaciente.AutoCompleteCustomSource.Clear();
            foreach (var item in ListaPacientesCadastrados)
            {
                txNomePaciente.AutoCompleteCustomSource.Add(item.NomePaciente);
            }
        }
    }
}
