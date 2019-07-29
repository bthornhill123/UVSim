using System;
using System.Collections.Generic;
using System.Text;

namespace UVSimLibrary.Models
{
    public class WordModel
    {
        public int MemoryLocation { get; set; }
        // TODO - Use OperationModel instead of string
        public string Operation { get; set; } // First 2 digits (command)
        public string Operand { get; set; } // Last 2 digits (operand/memory location)
        public string FullWord => $"{MemoryLocation} {Operation} {Operand}";

        // TODO - Implement this function by matching opCodes to their cooresponding operation
        public string GetOpcodesMatchingOperation(int opCode)
        {
            string output = "";

            switch (opCode)
            {
                default:
                    break;
            }

            return output;
        }
    }
}
