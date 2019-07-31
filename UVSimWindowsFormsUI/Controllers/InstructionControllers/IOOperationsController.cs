using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UVSimWindowsFormsUI.Models;
using UVSimWindowsFormsUI.HelperClasses;

namespace UVSimWindowsFormsUI.Controllers.InstructionControllers
{
    public static class IOOperationsController
    {
        //I/O Operations
        public static void Read(this UVSimModel uvSim, string operand)
        {
            string input = Prompt.ShowDialog("Enter an integer:", "Read Operation");
            input = input.PadLeft(4, '0');

            uvSim.Memory[int.Parse(operand)] = input;

            uvSim.OutputTextblock.Text += "Enter an integer: " + input + "\n";
        }
        public static void Write(this UVSimModel uvSim, string operand)
        {
            //Jaren Flaker
            string output = "Output: " + uvSim.Memory[int.Parse(operand)];

            uvSim.OutputTextblock.Text += output;
        }

        //Load/Store Operations
        public static void Load(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator += int.Parse(uvSim.Memory[int.Parse(operand)]);
        }
        public static void Store(this UVSimModel uvSim, string operand)
        {
            uvSim.Memory[int.Parse(operand)] = uvSim.Accumulator.ToString();
        }
    }
}
