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
    public partial class frmIncluirEstabelecimento : frmModelo
    {
        EstabelecimentoSaude ObjEstabelecimentoSaude = new EstabelecimentoSaude();
        public int IdEstabelecimento;

        public frmIncluirEstabelecimento()
        {
            InitializeComponent();
            
        }

        private void frmIncluirEstabelecimento_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txNome;
        }

        private void txNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ObjEstabelecimentoSaude.NomeEstabelecimento = txNome.Text.ToUpper();
                bool stopErro = true;
                foreach (char caractere in ObjEstabelecimentoSaude.NomeEstabelecimento)
                {
                    if (caractere!= 32)
                    {
                        if (caractere < 65 || caractere > 90)
                        {
                            MessageBox.Show("Não utilize acentuação ou caracteres especiais:\n^`:'çáéí...");
                            stopErro = false;
                            ObjEstabelecimentoSaude.NomeEstabelecimento = "";
                            break;
                        }
                    }
                }

                if (stopErro)
                {
                    txLogradouro.ReadOnly = false;
                    this.ActiveControl = txLogradouro;
                }
            }
        }
    }
}
