using System;
using System.Collections.Generic;
using System.Text;

namespace UVSimLibrary.Models
{
    public class UVSimModel
    {
        public List<WordModel> Memory { get; set; }
        public int ProgramCounter { get; private set; } = 0;
        public int Accumulator { get; private set; } = 0;
        public int MemorySize { get; private set; }

        public UVSimModel(int memorySize = 100)
        {
            MemorySize = memorySize;
        }
    }
}
