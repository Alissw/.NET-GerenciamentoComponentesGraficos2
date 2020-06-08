using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        public void btnConfirmar_Click(object Sender, EventArgs e){
                if(validarNome()){
                    this.nomeErro.SetError(this.txtbNome, String.Empty);
                }
                else
                {
                    this.nomeErro.SetError(this.txtbNome, "Por favor, preencha o campo para continuar...");
                }


                if(validarEmail()){
                    this.emailErro.SetError(this.txtbEmail, String.Empty);
                }
                else
                {
                    this.emailErro.SetError(this.txtbEmail, "Por favor, preencha o campo para continuar...");
                }
        }
        public bool validarNome(){
            return (txtbNome.Text.Length > 0);
        }

        public bool validarEmail(){
            return (txtbEmail.Text.Length > 0);
        }        
    }
}
