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

        // Ben Thornhill
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(memorySizeText.Text, out int result) == false)
            {
                MessageBox.Show("Please enter a valid memory size.");
            }
            else if (result > 1000){
                MessageBox.Show("Memory size is only supported currently up to 1000.");
            }
            else
            {
                UVSimDashboard app = new UVSimDashboard(result);
                app.Show();
            }
        }
    }
}
