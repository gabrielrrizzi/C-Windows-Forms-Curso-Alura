using CursoWindowsForms.User_Controls;
using System;
using System.Windows.Forms;
using CursoWindowsForms.Views_Curse_1;
using System.Drawing;
using CursoWindowsForms.Formulários_Curso2.User_Controls;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0, ControleDemonstracaoKey = 0, ControleMascara = 0, ControleValidaCPF = 0, ControleValidaCPF2 = 0, ControleValidaSenha = 0, ControleArquivoImagem = 0, ControleCadastroClientes = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            desconectarToolStripMenuItem.Enabled = false;
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey++;
            Frm_DemonstracaoKey_UC frm_DemonstracaoKey_UC = new Frm_DemonstracaoKey_UC();
            frm_DemonstracaoKey_UC.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demonstracao Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstracao Key " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(frm_DemonstracaoKey_UC);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld++;
            Frm_HelloWorld_UC frm_HelloWorld_UC = new Frm_HelloWorld_UC();
            frm_HelloWorld_UC.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_HelloWorld_UC);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara++;
            Frm_Mascara_UC frm_Mascara_UC = new Frm_Mascara_UC();
            frm_Mascara_UC.Dock = DockStyle.Fill;
            TabPage Tbc = new TabPage();
            Tbc.Name = "Mascara " + ControleMascara;
            Tbc.Text = "Mascara " + ControleMascara;
            Tbc.ImageIndex = 2;
            Tbc.Controls.Add(frm_Mascara_UC);
            Tbc_Aplicacoes.TabPages.Add(Tbc);

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            if (frm_Login.DialogResult == DialogResult.OK)
            {

                string senha = frm_Login.senha;
                string usuario = frm_Login.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.ValidaSenhaLogin(senha) == true)
                {
                    conectarToolStripMenuItem.Enabled = false;
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + usuario + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao frm_Questao = new Frm_Questao("Question", "Você deseja se desconectar?");
            frm_Questao.ShowDialog();
            if (frm_Questao.DialogResult == DialogResult.Yes)
            {
                conectarToolStripMenuItem.Enabled = true;
                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
                MessageBox.Show("Desconectado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }
            }

        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;/*
                //MessageBox.Show("A posição relativa foi: " +"("+ PosicaoX.ToString() + ";" + PosicaoY.ToString()+")");*/

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar todas a Esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar todas a direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);

                ContextMenu.Show(this,/*e.Location*/new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);

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
        void vToolTip001_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip002_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                for (int i = Tbc_Aplicacoes.SelectedIndex - 1; i >= 0; i += -1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }
            }

        }

        void vToolTip003_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i > Tbc_Aplicacoes.SelectedIndex; i += -1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }
            }
        }

        void vToolTip004_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                int TabSelecionada = Tbc_Aplicacoes.SelectedIndex;
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    if (i != TabSelecionada)
                    {
                        ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                    }
                }
            }
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;

            return vToolTip;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes++;
                Frm_CadastroUsuario_UC frm_CadastroUsuario_UC = new Frm_CadastroUsuario_UC();
                frm_CadastroUsuario_UC.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Cadastro Cliente";
                TB.Text = "Cadastro Cliente";
                TB.ImageIndex = 7;
                TB.Controls.Add(frm_CadastroUsuario_UC);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de cliente pois já está aberto", "Byte Bank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\WindowsForms\Curso\CursoWindowsForms\windows-forms-parte-1-arquivos-aula-6\Icones_Imagens";
            ofd.Filter = "PNG| *.PNG";
            ofd.Title = "Escolha a Imagem";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string nomeArquivoImagem = ofd.FileName;
                ControleArquivoImagem++;
                Frm_ArquivoImagem_UC frm_ArquivoImagem_UC = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                frm_ArquivoImagem_UC.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControleValidaCPF;
                TB.Text = "Arquivo Imagem " + ControleValidaCPF;
                TB.ImageIndex = 6;
                TB.Controls.Add(frm_ArquivoImagem_UC);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF++;
            Frm_ValidaCPF_UC frm_ValidaCPF_UC = new Frm_ValidaCPF_UC();
            frm_ValidaCPF_UC.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valida CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(frm_ValidaCPF_UC);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2++;
            Frm_ValidaCPF2_UC frm_ValidaCPF2_UC = new Frm_ValidaCPF2_UC();
            frm_ValidaCPF2_UC.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = "Valida CPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(frm_ValidaCPF2_UC);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha++;
            Frm_ValidaSenha_UC frm_ValidaSenha_UC = new Frm_ValidaSenha_UC();
            frm_ValidaSenha_UC.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valida Senha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(frm_ValidaSenha_UC);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void ApagaAba(TabPage TB)
        {
            if(TB.Name == "Cadastro Cliente")
            {
                ControleCadastroClientes = 0;
            }

            Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
        }
    }
}
