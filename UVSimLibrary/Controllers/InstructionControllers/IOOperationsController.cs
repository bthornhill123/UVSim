using System;
using System.Collections.Generic;
using System.Text;
using UVSimLibrary.HelperClasses;
using UVSimLibrary.Models;

namespace UVSimLibrary.Controllers.InstructionControllers
{
    public static class IOOperationsController
    {
        //I/O Operations
        public static void Read(this UVSimModel uvSim, string operand)
        {
            string input = Prompt.ShowDialog("Enter an integer:", "Read Operation");
            Console.Write("Enter an Integer: ");
            //memory[operand] = input;

        }
        public static void Write(this UVSimModel uvSim, string operand)
        {
            //Console.WriteLine("Contents of location {0}: {1}", operand, memory[int.Parse(operand)]);
        }

        //Load/Store Operations
        public static void Load(this UVSimModel uvSim, string operand)
        {
            // accumulator = int.Parse(memory[int.Parse(operand)]);
        }
        public static void Store(this UVSimModel uvSim, string operand)
        {
            // memory[operand] = accumulator.ToString();
        }
    }
}
