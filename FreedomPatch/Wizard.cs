using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreedomPatch
{
    // Class to hold the Wizard controls
    public partial class Wizard : Form
    {
        // https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Wizard()
        {
            InitializeComponent();
        }

        private void form_wizard_Load(object sender, EventArgs e) {
        }

        private void form_wizard_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Page to the next page if we are not already at the end of the TabControl
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (tabs_wizard.SelectedIndex < tabs_wizard.TabCount - 1) {
                tabs_wizard.SelectedIndex++;
                progress_wizard.Value = tabs_wizard.SelectedIndex;
                lbl_wizard_progress.Text = (tabs_wizard.SelectedIndex + 1) + " of 12";
                if (tabs_wizard.SelectedIndex == tabs_wizard.TabCount - 1) {
                    btn_next.Text = "Finish";
                } else {
                    btn_next.Text = "Next";
                }
            }
        }

        // This this form behind
        private void btn_exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void radio_cortana_off_CheckedChanged(object sender, EventArgs e) {

        }

        // Page back if we are not already at the beginning
        private void btn_back_Click(object sender, EventArgs e) {
            if (tabs_wizard.SelectedIndex > 0) {
                tabs_wizard.SelectedIndex--;
                progress_wizard.Value = tabs_wizard.SelectedIndex;
                lbl_wizard_progress.Text = (tabs_wizard.SelectedIndex + 1) + " of 12";
                btn_next.Text = "Next";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
