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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;/*
                //MessageBox.Show("A posição relativa foi: " +"("+ PosicaoX.ToString() + ";" + PosicaoY.ToString()+")");*/

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item 2", "Frm_ValidaSenha");

                

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this,/*e.Location*/new Point(e.X,e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

                /* var ContextMenu = new ContextMenuStrip();

                 var vItem1 = new ToolStripMenuItem();
                 var vItem2 = new ToolStripMenuItem();
                 var vItem3 = new ToolStripMenuItem();
                 var vItem11 = new ToolStripMenuItem();
                 var vItem12 = new ToolStripMenuItem();

                 vItem1.Text = "Menu 1";
                 vItem2.Text = "Menu 2";
                 vItem3.Text = "Menu 3";
                 vItem11.Text = "Menu 1.1";
                 vItem12.Text = "Menu 1.2";

                 vItem1.DropDownItems.Add(vItem11);
                 vItem1.DropDownItems.Add(vItem12);

                 ContextMenu.Items.Add(vItem1);
                 ContextMenu.Items.Add(vItem2);
                 ContextMenu.Items.Add(vItem3);

                 ContextMenu.Show(this, new Point(e.X, e.Y));*/

            }
        }

        void vToolTip001_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Selecionei a opção 001");
        }

        void vToolTip002_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionei a opção 002");
        }

        ToolStripMenuItem DesenhaItemMenu(string text,string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;

            return vToolTip;
        }

    }
}
