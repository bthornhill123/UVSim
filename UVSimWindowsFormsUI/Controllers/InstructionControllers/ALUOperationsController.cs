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
        //ALU
        public static void Add(this UVSimModel uvSim, string operand)
        {
            /*accumulator += int.Parse(memory[operand]);*/
            // uvSim.Add()'

            //string o1 = uvSim.Memory[int.Parse(operand)].Operation;
            //string o2 = uvSim.Memory[int.Parse(operand)].Operand;

            //uvSim.Accumulator = new WordModel { Operation = o1, Operand = o2 };

            uvSim.Accumulator += int.Parse(uvSim.Memory[int.Parse(operand)]);
        }
        public static void Subtract(this UVSimModel uvSim, string operand) {/* accumulator -= int.Parse(memory[operand]); */}
        public static void Divide(this UVSimModel uvSim, string operand) { /*accumulator /= int.Parse(memory[operand]);*/ }
        public static void Multiply(this UVSimModel uvSim, string operand) { /*accumulator *= int.Parse(memory[operand]);*/ }
    }
}
