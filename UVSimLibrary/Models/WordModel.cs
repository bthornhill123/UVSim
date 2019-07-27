using System;
using System.Collections.Generic;
using System.Text;

namespace UVSimLibrary.Models
{
    public class WordModel
    {
        public int MemoryLocation { get; set; }
        public string Operation { get; set; } // First 2 digits (command)
        public string Operand { get; set; } // Last 2 digits (operand/memory location)
    }
}
