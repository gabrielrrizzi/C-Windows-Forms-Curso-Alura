using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.User_Controls
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem_UC.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog DLG = new ColorDialog();    
           
            if(DLG.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = DLG.Color;    
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDB = new FontDialog();
            if(FDB.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDB.Font;
            }
        }
    }
}
