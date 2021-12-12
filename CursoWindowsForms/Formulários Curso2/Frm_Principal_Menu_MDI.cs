using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_MDI : Form
    {
        public Frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemostracaoKey frm_DemostracaoKey = new Frm_DemostracaoKey();
            frm_DemostracaoKey.MdiParent = this;
            frm_DemostracaoKey.Show();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld frm_HelloWorld = new Frm_HelloWorld();
            frm_HelloWorld.MdiParent = this;
            frm_HelloWorld.Show();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara frm_Mascara = new Frm_Mascara();
            frm_Mascara.MdiParent = this;
            frm_Mascara.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF frm_ValidaCPF = new Frm_ValidaCPF();
            frm_ValidaCPF.MdiParent = this;
            frm_ValidaCPF.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 frm_ValidaCPF2 = new Frm_ValidaCPF2();
            frm_ValidaCPF2.MdiParent = this;
            frm_ValidaCPF2.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha frm_ValidaSenha = new Frm_ValidaSenha();
            frm_ValidaSenha.MdiParent = this;
            frm_ValidaSenha.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}


