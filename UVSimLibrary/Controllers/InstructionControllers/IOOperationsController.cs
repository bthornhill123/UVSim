﻿using System;
using System.Collections.Generic;
using System.Text;
using UVSimLibrary.HelperClasses;
using UVSimLibrary.Models;
using System.Linq;

namespace UVSimLibrary.Controllers.InstructionControllers
{
    public static class IOOperationsController
    {
        //I/O Operations
        public static void Read(this UVSimModel uvSim, string operand)
        {
            string input = Prompt.ShowDialog("Enter an integer:", "Read Operation");

            uvSim.Memory[int.Parse(operand)] = input;

            // TODO - Output "Enter an integer: {input}" to the output textblock
            uvSim.Output += "Enter an integer: " + input + "\n";
        }
        public static void Write(this UVSimModel uvSim, string operand)
        {
            //Console.WriteLine("Contents of location {0}: {1}", operand, memory[int.Parse(operand)]);
            uvSim.Output += "Contentis of location " + operand + " is " + uvSim.Memory[int.Parse(operand)];
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
