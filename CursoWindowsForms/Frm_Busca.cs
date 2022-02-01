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
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string IdSelect { get; set; }
        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar o formulário";
            PreencherLista(); 
            lst_Busca.Sorted = true;
        }
        private void PreencherLista()
        {
            lst_Busca.Items.Clear();

            for(int i = 0;i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox x = new ItemBox();
                x.ID = _ListaBusca[i][0];
                x.Nome = _ListaBusca[i][1];

                lst_Busca.Items.Add(x);
                
            }
            
        }
        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_Busca_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado  = (ItemBox)lst_Busca.Items[lst_Busca.SelectedIndex] ;
            IdSelect = ItemSelecionado.ID;
            this.Close();
        }

        class ItemBox
        {
            public string ID { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
