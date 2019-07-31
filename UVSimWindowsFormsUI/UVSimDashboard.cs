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

            RefreshMemoryListbox();


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

            bool isBreakpoint = shouldBreakHere.Checked;
            string breakPoint = (isBreakpoint) ? "11" : "00";

            string operand = operandValue.Text.PadLeft(4, '0');

            string command = operation + breakPoint + operand;

            if (command.Length > 8)
                MessageBox.Show("Error adding command.\n The specified operand couldn't be processed.");
            else
                AddCommandToListbox(command);
        }

        public void AddCommandToListbox(string command)
        {
            uvSim.Memory[currentMemoryLocation++] = command.Substring(0, 4);
            uvSim.Memory[currentMemoryLocation++] = command.Substring(4, 4);

            RefreshMemoryListbox();
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {
            runProgramButton.Text = "Run Program";
            runProgramButton.BackColor = Color.Honeydew;

            try
            {
                uvSim.RunProgram();
                uvSim.ProgramCounter = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                runProgramButton.Text = "Continue";
                runProgramButton.BackColor = Color.LightYellow;
            }
            finally
            {
                uvSim.DisplayMemory();
                uvSim.DisplayRegisterStats();
            }
        }

        private void DumpMemoryButton_Click(object sender, EventArgs e)
        {
            uvSim.DisplayMemory();
        }

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            uvSim.OutputTextblock.Text = "";
        }

        private void ResetProgramButton_Click(object sender, EventArgs e)
        {
            uvSim.InitializeMemory();
            currentMemoryLocation = 0;
            RefreshMemoryListbox();
        }

        private void RefreshMemoryListbox()
        {
            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = uvSim.Memory;
        }

        private void DisplayUserManual_Click(object sender, EventArgs e)
        {
            string userManual = "";

            // TODO - Display a detailed user manual to the user

            outputTextblock.Text = userManual;
        }
    }
}
