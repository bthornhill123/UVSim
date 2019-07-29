using System;
using System.Collections.Generic;
using System.Text;
using UVSimLibrary.Models;

namespace UVSimLibrary.Controllers.InstructionControllers
{
    public static class ALUOperationsController
    {
        //ALU
        public static void Add(this UVSimModel uvSim, string operand) { /*accumulator += int.Parse(memory[operand]);*/ }
        public static void Subtract(this UVSimModel uvSim, string operand) {/* accumulator -= int.Parse(memory[operand]); */}
        public static void Divide(this UVSimModel uvSim, string operand) { /*accumulator /= int.Parse(memory[operand]);*/ }
        public static void Multiply(this UVSimModel uvSim, string operand) { /*accumulator *= int.Parse(memory[operand]);*/ }
    }
}
