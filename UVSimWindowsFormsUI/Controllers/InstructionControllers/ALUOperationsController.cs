using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVSimWindowsFormsUI.Models;

namespace UVSimWindowsFormsUI.Controllers.InstructionControllers
{
    public static class ALUOperationsController
    {
        // Cameron Prestera
        public static void Subtract(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator -= int.Parse(uvSim.Memory[int.Parse(operand)]);
        }

        // Cameron Prestera
        public static void Divide(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator /= int.Parse(uvSim.Memory[int.Parse(operand)]);
        }
        // Cameron Prestera
        public static void Multiply(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator *= int.Parse(uvSim.Memory[int.Parse(operand)]);
        }

        // Cameron Prestera
        public static void Add(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator += int.Parse(uvSim.Memory[int.Parse(operand)]);
        }

        //Jaren Flaker
        public static void Remainder(this UVSimModel uvSim, string operand)
        {
            uvSim.Accumulator %= int.Parse(uvSim.Memory[int.Parse(operand)]);
        }

        //Jaren Flaker
        public static void Exponent(this UVSimModel uvSim, string operand)
        {
            int exponent = int.Parse (uvSim.Memory[int.Parse(operand)]);
            uvSim.Accumulator = (int)Math.Pow((double)uvSim.Accumulator, (double)exponent);
        }

    }
}
