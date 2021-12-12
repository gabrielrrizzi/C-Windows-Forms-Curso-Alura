using CursoWindowsForms.User_Controls;
using System;
using System.Windows.Forms;
using CursoWindowsForms.Views_Curse_1;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0, ControleDemonstracaoKey = 0, ControleMascara = 0, ControleValidaCPF = 0, ControleValidaCPF2 = 0, ControleValidaSenha = 0, ControleArquivoImagem = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            desconectarToolStripMenuItem.Enabled = false;
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
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
            Frm_Questao frm_Questao = new Frm_Questao("Question Photo", "Você deseja se desconectar?");
            frm_Questao.ShowDialog();
            if (frm_Questao.DialogResult == DialogResult.Yes)
            {
                conectarToolStripMenuItem.Enabled = true;
                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                MessageBox.Show("Desconectado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for(int i = Tbc_Aplicacoes.TabPages.Count - 1; i>= 0; i += -1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]); 
                }
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
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }

        }
    }
}
