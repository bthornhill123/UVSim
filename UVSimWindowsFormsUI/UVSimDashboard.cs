using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVSimLibrary;
using UVSimLibrary.Models;

namespace UVSimWindowsFormsUI
{
    public partial class UVSimDashboard : Form
    {
        List<string> commands = new List<string>();

        public UVSimDashboard(int memorySize)
        {
            InitializeComponent();

            UVSim sim = new UVSim(memorySize);

            Thread t = new Thread(() =>
            {
                Thread.Sleep(500);
                sim.FetchUserManual();
            });
            t.Start();
        }

        private void SubmitCommandDirectButton_Click(object sender, EventArgs e)
        {
            string command = commandValue.Text;
            commands.Add(command);

            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = commands;
        }
    }
}
