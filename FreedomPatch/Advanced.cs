using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreedomPatch
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void Advanced_Load(object sender, EventArgs e)
        {

        }

        private void btn_give_up_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://getfedora.org/");
        }
    }
}
