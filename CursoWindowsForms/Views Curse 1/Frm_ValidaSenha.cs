using System;
using System.Drawing;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForms
{

    public partial class Frm_ValidaSenha : Form
    {
        bool VerSenhaTxt = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha checaForcaSenha = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = checaForcaSenha.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if(Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.DarkRed;
            }if(Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.RoyalBlue;
            }if(Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_Valida.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_Valida.Text = "Ver Senha";
            }
        }
    }

}
