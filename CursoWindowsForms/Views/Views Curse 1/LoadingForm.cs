using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Views.Views_Curse_1
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            WaitSomeTime();
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Close();
        }
    }
}
