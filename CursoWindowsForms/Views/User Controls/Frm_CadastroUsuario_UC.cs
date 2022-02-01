using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Cliente;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classe;
<<<<<<< HEAD
using CursoWindowsFormsBiblioteca.Databases;
=======
>>>>>>> 5c0450bf6145a409b9f3976a6eb70ab48a488636

namespace CursoWindowsForms.Formulários_Curso2.User_Controls
{
    public partial class Frm_CadastroUsuario_UC : UserControl
    {
        public Frm_CadastroUsuario_UC()
        {
            InitializeComponent();
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Genero.Text = "Genero";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_NomeMaee.Text = "Nome da Mãe";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereco";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir um cliente na base";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Atualiza o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpar Campos";
<<<<<<< HEAD

            btn_Busca.Text = "Buscar";
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_Bairro.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Chk_TemPai.Checked = false;
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomePai.Text = "";
            Txt_NomeMaee.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = "";
            Txt_Telefone.Text = "";
            Txt_Cidade.Text = "";
            Rdb_Masculino.Checked = true;
=======
>>>>>>> 5c0450bf6145a409b9f3976a6eb70ab48a488636
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
<<<<<<< HEAD
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraFormulario();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
                cliente.IncluirFichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                MessageBox.Show("Ok: Cliente incluído com sucesso!");

                /*  string clienteJson = Cliente.SerializedClassUnit(cliente);

                  Fichario f = new Fichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                  if (f.status)
                  {
                      f.Incluir(cliente.ID, clienteJson);
                      if (f.status)
                      {
                          MessageBox.Show("Ok: " + f.message);
                      }
                      else
                      {
                          MessageBox.Show("Err: " + f.message);
                      }
                  }
                  else
                  {
                      MessageBox.Show("Err: " + f.message);
                  }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit cliente = new Cliente.Unit();
                    
                    cliente = cliente.BuscarFichario(Txt_Codigo.Text, @"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                   
                    if(cliente != null)
                    {
                        EscreveFormulario(cliente);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                    
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

                /*Fichario f = new Fichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                if (f.status)
                {
                    string clienteJson = f.Buscar(Txt_Codigo.Text);
                    Cliente.Unit cliente = new Cliente.Unit();
                    cliente = Cliente.DesSerializedClassUnit(clienteJson);
                    if (cliente.ID.Length > 0 && cliente != null)
                    {
                        EscreveFormulario(cliente);
                    }

                }
                else
                {
                    MessageBox.Show("Erro na conexão", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }



        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Codigo.Text == "")
                {
                    MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente.Unit cliente = new Cliente.Unit();
                    cliente = LeituraFormulario();
                    cliente.ValidaClasse();
                    cliente.ValidaComplemento();
                    string clienteJson = Cliente.SerializedClassUnit(cliente);

                    MessageBox.Show("Cliente alterado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente.Unit cliente = new Cliente.Unit();
                
                cliente = cliente.BuscarFichario(Txt_Codigo.Text, @"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                if(cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    return;
                }
                EscreveFormulario(cliente);

                Frm_Questao Db = new Frm_Questao("Question", "Você quer excluir o cliente");
                Db.ShowDialog();

                if (Db.DialogResult == DialogResult.Yes)
                {
                    cliente.ApagarFichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                    MessageBox.Show("Identificador apagado com sucesso","ByteBank",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                /* Fichario f = new Fichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");

                 string clienteJson = f.Buscar(Txt_Codigo.Text);
                 Cliente.Unit cliente = new Cliente.Unit();
                 cliente = Cliente.DesSerializedClassUnit(clienteJson);
                 if (cliente.ID.Length > 0)
                 {
                     EscreveFormulario(cliente);
                 }

                 Frm_Questao Db = new Frm_Questao("Question", "Você quer excluir o cliente");
                 Db.ShowDialog();

                 if (Db.DialogResult == DialogResult.Yes)
                 {

                     if (f.status)
                     {

                         f.Apagar(Txt_Codigo.Text);
                         if (f.status)
                         {
                             MessageBox.Show("Ok: " + f.message);
                         }
                         else
                         {
                             MessageBox.Show("Err: " + f.message);
                         }
                     }
                     else
                     {
                         MessageBox.Show("Erro na conexão", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }*/
            }
            LimparFormulario();



        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit cliente = new Cliente.Unit();
            cliente.ID = Txt_Codigo.Text;
            cliente.Name = Txt_NomeCliente.Text;
            cliente.NomeDaMae = Txt_NomeMaee.Text;
            cliente.NomeDoPai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                cliente.NaoTemPai = true;
=======
            }
            else
            {
                Txt_NomePai.Enabled = true;
>>>>>>> 5c0450bf6145a409b9f3976a6eb70ab48a488636
            }
            else
            {
                cliente.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                cliente.Genero = 0;
            }
            else if (Rdb_Feminino.Checked)
            {
                cliente.Genero = 1;
            }
            else if (Rdb_Indefinido.Checked)
            {
                cliente.Genero = 2;
            }
            cliente.CPF = Txt_CPF.Text;
            cliente.CEP = Txt_CEP.Text;
            cliente.Logradouro = Txt_Logradouro.Text;
            cliente.Cidade = Txt_Cidade.Text;
            cliente.Bairro = Txt_Bairro.Text;
            cliente.Telefone = Txt_Telefone.Text;
            if (Cmb_Estados.SelectedIndex < 0)
            {
                cliente.Estado = "";
            }
            else
            {
                cliente.Estado = Cmb_Estados.SelectedItem.ToString();
            }
            cliente.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if (vRenda < 0)
                {
                    cliente.RendaFamiliar = 0;
                }
                else
                {
                    cliente.RendaFamiliar = vRenda;
                }
            }
            cliente.Complemento = Txt_Complemento.Text;

            return cliente;
        }

        private void EscreveFormulario(Cliente.Unit cliente)
        {
            Txt_Codigo.Text = cliente.ID;
            Txt_NomeCliente.Text = cliente.Name;
            Txt_NomeMaee.Text = cliente.NomeDaMae;
            Txt_NomePai.Text = cliente.NomeDoPai;
            Chk_TemPai.Checked = cliente.NaoTemPai;

            if (cliente.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            else if (cliente.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            else if (cliente.Genero == 2)
            {
                Rdb_Indefinido.Checked = true;
            }
            Txt_CPF.Text = cliente.CPF;
            Txt_CEP.Text = cliente.CEP;
            Txt_Logradouro.Text = cliente.Logradouro;
            Txt_Cidade.Text = cliente.Cidade;
            Txt_Bairro.Text = cliente.Bairro;
            Txt_Telefone.Text = cliente.Telefone;

            if (cliente.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                Cmb_Estados.SelectedIndex = Cmb_Estados.Items.IndexOf(cliente.Estado);
            }
            Txt_Profissao.Text = cliente.Profissao;
            Txt_RendaFamiliar.Text = cliente.RendaFamiliar.ToString();

            Txt_Complemento.Text = cliente.Complemento;


        }


        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if (vCep != "" && (vCep.Length == 8) && Information.IsNumeric(vCep))
            {
                var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                CEP.Unit Cep = new CEP.Unit();
                Cep = CEP.DesSerializedClassUnit(vJson);
                Txt_Logradouro.Text = Cep.logradouro;
                Txt_Bairro.Text = Cep.bairro;
                Txt_Cidade.Text = Cep.localidade;
                Cmb_Estados.SelectedIndex = -1;
                if (Cep.uf != null && Cep.uf != "")
                {
                    for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                    {
                        if (Cmb_Estados.Items[i].ToString().Contains(Cep.uf))
                        {
                            Cmb_Estados.SelectedIndex = i;
                        }
                    }
                }

            }
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                List<string> list = new List<string>();
                list = cliente.Buscar(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");
                if(list != null && list.Count != 0)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        Cliente.Unit c = Cliente.DesSerializedClassUnit(list[i]);
                        ListaBusca.Add(new List<string> { c.ID, c.Name });
                    }
                    Frm_Busca frm_busca = new Frm_Busca(ListaBusca);
                    frm_busca.ShowDialog();
                    if (frm_busca.DialogResult == DialogResult.OK)
                    {
                        var IdSelect = frm_busca.IdSelect;
                        Txt_Codigo.Text = IdSelect.ToString();
                        openToolStripButton.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Base de dados esta vazia, não temos nenhum cliente cadastrado");
                }
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            /*List<string> list = new List<string>();
            Fichario f = new Fichario(@"E:\WindowsForms\Curso\CursoWindowsForms(Parte5)\Fichario");

            if (f.status)
            {
                list = f.BuscarTodos();
                List<List<string>> ListaBusca = new List<List<string>>();
                for(int i = 0; i <= list.Count - 1; i++)
                {
                    Cliente.Unit c = Cliente.DesSerializedClassUnit(list[i]);
                    ListaBusca.Add(new List<string> { c.ID, c.Name });

                }
                
                Frm_Busca frm_busca = new Frm_Busca(ListaBusca);
                frm_busca.ShowDialog();
                if(frm_busca.DialogResult == DialogResult.OK)
                {
                    var IdSelect = frm_busca.IdSelect;                                                  
                    Txt_Codigo.Text = IdSelect.ToString();
                    openToolStripButton.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Err: " + f.message,"ByteBank",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraFormulario();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
                MessageBox.Show("Classe inserida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {

        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit cliente = new Cliente.Unit();
            cliente.ID = Txt_Codigo.Text;
            cliente.Name = Txt_NomeCliente.Text;
            cliente.NomeDaMae = Txt_NomeMaee.Text;
            cliente.NomeDoPai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                cliente.NaoTemPai = true;
            }
            else
            {
                cliente.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                cliente.Genero = 0;
            }else if (Rdb_Feminino.Checked)
            {
                cliente.Genero = 1;
            }
            else if (Rdb_Indefinido.Checked)
            {
                cliente.Genero = 2;
            }
            cliente.CPF = Txt_CPF.Text;
            cliente.CEP = Txt_CEP.Text;
            cliente.Logradouro = Txt_Logradouro.Text;
            cliente.Cidade = Txt_Cidade.Text;
            cliente.Bairro = Txt_Bairro.Text;
            cliente.Telefone = Txt_Telefone.Text;
            if(Cmb_Estados.SelectedIndex < 0)
            {
                cliente.Estado = "";
            }
            else
            {
                cliente.Estado = Cmb_Estados.SelectedItem.ToString();  
            }
            cliente.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if(vRenda < 0)
                {
                    cliente.RendaFamiliar = 0;
                }
                else
                {
                    cliente.RendaFamiliar = vRenda;
                }
            }
            cliente.Complemento = Txt_Complemento.Text;

            return cliente;
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if(vCep != "" && (vCep.Length == 8) && Information.IsNumeric(vCep))
            {
                var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                CEP.Unit Cep = new CEP.Unit();
                Cep = CEP.DesSerializedClassUnit(vJson);
                Txt_Logradouro.Text = Cep.logradouro;
                Txt_Bairro.Text = Cep.bairro;
                Txt_Cidade.Text = Cep.localidade;
                Cmb_Estados.SelectedIndex = -1;
                if(Cep.uf != null && Cep.uf !="")
                {
                    for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                    {
                        if (Cmb_Estados.Items[i].ToString().Contains(Cep.uf))
                        {
                            Cmb_Estados.SelectedIndex = i;
                        }
                    }
                }
               
            }    
        }
    }
}
