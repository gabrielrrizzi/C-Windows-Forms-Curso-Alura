using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem,string mensagem)
        {
            InitializeComponent();
            Image myImage= (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = myImage;
            Lbl_Questao.Text = mensagem;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
