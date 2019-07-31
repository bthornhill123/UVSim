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
using UVSimWindowsFormsUI.Controllers.InstructionControllers;
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
            uvSim.OutputTextblock = outputTextblock;
            uvSim.MemoryTextblock = memoryTextblock;

            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = uvSim.Memory;


            uvSim.DisplayGreeting();
        }

        private void PopulateOperationsListbox()
        {
            List<OperationModel> operations = uvSim.GetAvailableOperations();

            operationsDropdown.DataSource = operations;
            operationsDropdown.DisplayMember = nameof(OperationModel.Name);
        }

       

        private void SubmitCommandEasyButton_Click(object sender, EventArgs e)
        {
            OperationModel selectedOperation = (OperationModel)operationsDropdown.SelectedItem;

            string operation = selectedOperation.OpCode;
            string operand = operandValue.Text;
            string command = operation + operand;

            AddCommandToListbox(command);

            //uvSim.Read("10");
        }

        public void AddCommandToListbox(string command)
        {
            uvSim.Memory[currentMemoryLocation] = command;
            //commands.Add(command);

            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = uvSim.Memory;

            currentMemoryLocation++;
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {
            uvSim.RunProgram();

            uvSim.DisplayMemory();
        }

        private void DumpMemoryButton_Click(object sender, EventArgs e)
        {
            uvSim.DisplayMemory();
        }

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            uvSim.OutputTextblock.Text = "";
        }

    }
}
