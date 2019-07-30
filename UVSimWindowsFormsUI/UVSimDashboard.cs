using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVSimWindowsFormsUI.Controllers;
using UVSimWindowsFormsUI.Models;

// TODO - Add in functionality to delete last command (this will need to decrement the currentMemoryLocation)
// TODO - Add button that shows user manual with all of the instructions and their corresponding op codes

namespace UVSimWindowsFormsUI
{
    public partial class UVSimDashboard : Form
    {
        List<string> commands = new List<string>();
        int currentMemoryLocation = 0;
        UVSimModel uvSim;

        public UVSimDashboard(int memorySize)
        {
            InitializeComponent();

            PopulateOperationsListbox();

            uvSim = new UVSimModel(memorySize);

            Thread t = new Thread(() =>
            {
                Thread.Sleep(500);
                uvSim.DisplayGreeting();
            });
            t.Start();
        }

        private void PopulateOperationsListbox()
        {
            List<OperationModel> operations = uvSim.GetAvailableOperations();

            operationsDropdown.DataSource = operations;
            operationsDropdown.DisplayMember = nameof(OperationModel.Name);
        }

        private void SubmitCommandDirectButton_Click(object sender, EventArgs e)
        {
            string command = commandValue.Text;

            AddCommandToListbox(command);
        }

        private void SubmitCommandEasyButton_Click(object sender, EventArgs e)
        {
            OperationModel selectedOperation = (OperationModel)operationsDropdown.SelectedItem;

            string operation = selectedOperation.OpCode;
            string operand = operandValue.Text;
            string command = operation + operand;

            AddCommandToListbox(command);
        }

        public void AddCommandToListbox(string command)
        {
            commands.Add(command);

            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = commands;

            currentMemoryLocation++;
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {


            memoryTextblock.Text = uvSim.GetMemoryDump();

            outputTextblock.Text = uvSim.Output;
        }
    }
}
