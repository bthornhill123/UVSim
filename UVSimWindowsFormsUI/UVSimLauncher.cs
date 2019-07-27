using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVSimWindowsFormsUI
{
    public partial class UVSimForm : Form
    {
        public UVSimForm()
        {
            InitializeComponent();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(memorySizeText.Text, out int result) == false)
            {
                
            }
            else
            {
                UVSimDashboard app = new UVSimDashboard(result);
                app.Show();
            }
        }
    }
}
