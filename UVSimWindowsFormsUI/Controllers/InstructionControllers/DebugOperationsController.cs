using System;
using System.Collections.Generic;
using System.Text;
using UVSimWindowsFormsUI.Models;

namespace UVSimWindowsFormsUI.Controllers.InstructionControllers
{
    public static class DebugOperationsController
    {
        //Debugging Operations

        //Todo - Create button for memdump
        public static void MemDump(this UVSimModel uvSim)
        {
            //Console.WriteLine("\nAccumilator: {0:d2}\nOpcode: {1:d2}\nOperand: {2:d2}\n\nMemory Dump: ", accumulator, opcode, operand);
            //for (int i = 0; i < MEM_SIZE; i++)
            //{
            //    Console.WriteLine("{0:d2}: {1}", i, memory[i]);
            //}
        }
    }
}
