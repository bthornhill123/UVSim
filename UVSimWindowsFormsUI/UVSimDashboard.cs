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
using UVSimLibrary;
using UVSimLibrary.Controllers;
using UVSimLibrary.Models;

// TODO - Add in functionality to delete last command (this will need to decrement the currentMemoryLocation)
// TODO - Add button that shows user manual with all of the instructions and their corresponding op codes

namespace UVSimWindowsFormsUI
{
    public partial class UVSimDashboard : Form
    {
        List<WordModel> commands = new List<WordModel>();
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

            string operation = command.Substring(0, 2);
            string operand = command.Substring(2, 2);

            AddCommandToListbox(operation, operand);
        }

        private void SubmitCommandEasyButton_Click(object sender, EventArgs e)
        {
            OperationModel selectedOperation = (OperationModel)operationsDropdown.SelectedItem;

            string operation = selectedOperation.OpCode;
            string operand = operandValue.Text;

            AddCommandToListbox(operation, operand);
        }

        public void AddCommandToListbox(string operation, string operand)
        {
            commands.Add(new WordModel { Operation = operation, Operand = operand, MemoryLocation = currentMemoryLocation });

            currentProgramListbox.DataSource = null;
            currentProgramListbox.DataSource = commands;
            currentProgramListbox.DisplayMember = nameof(WordModel.FullWord);

            currentMemoryLocation++;
        }
    }
}
