using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    partial class Cadastro
    {
        private System.ComponentModel.IContainer components = null;
       public FlowLayoutPanel FlowlayoutTopDown;
       public FlowLayoutPanel FlowlayoutRight;
        ErrorProvider nomeErro;
        ErrorProvider emailErro;
         Label lbNome;
         Label lbEmail;
         TextBox txtbNome;
         TextBox txtbEmail;
         Button btnConfirmar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Cadastro";
            
     
            //FlowLayoutPanel
            this.FlowlayoutTopDown = new FlowLayoutPanel();
            this.FlowlayoutTopDown.FlowDirection = FlowDirection.TopDown;
            this.FlowlayoutTopDown.Dock = DockStyle.Fill;
            
            //Componentes
            lbNome = new lib.Label();
            lbNome.Text = "Nome:";
            txtbNome = new lib.TextBox();
   
            lbEmail = new lib.Label();
            lbEmail.Text = "E-mail:";
            txtbEmail = new lib.TextBox();
   
            
            btnConfirmar = new lib.Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
    
            //ErrorProviderNome
            this.nomeErro = new ErrorProvider();
            this.nomeErro.SetIconAlignment(this.txtbNome, ErrorIconAlignment.MiddleRight);
            this.nomeErro.SetIconPadding(this.txtbNome, 3);
            this.nomeErro.BlinkRate = 10000;
            this.nomeErro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            
            // //ErrorProviderEmail
            this.emailErro = new ErrorProvider();
            this.emailErro.SetIconAlignment(this.txtbEmail, ErrorIconAlignment.MiddleRight);
            this.emailErro.SetIconPadding(this.txtbEmail, 3);
            this.emailErro.BlinkRate = 10000;
            this.emailErro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            

            this.Size = new Size(300,300);
            this.BackColor = Color.Yellow;

            this.FlowlayoutTopDown.Controls.Add(lbNome);
            this.FlowlayoutTopDown.Controls.Add(txtbNome);
            this.FlowlayoutTopDown.Controls.Add(lbEmail);
            this.FlowlayoutTopDown.Controls.Add(txtbEmail);
            this.FlowlayoutTopDown.Controls.Add(btnConfirmar);
            
            
            this.Controls.Add(this.FlowlayoutTopDown);

        }

    }
}

