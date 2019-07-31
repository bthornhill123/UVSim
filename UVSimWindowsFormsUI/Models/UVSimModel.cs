using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace UVSimWindowsFormsUI.Models
{
    public class UVSimModel
    {
        public List<string> Memory { get; set; }
        public int ProgramCounter { get; set; } = 0;
        public int Accumulator { get; set; }
        public int MemorySize { get; set; }

        public RichTextBox OutputTextblock { get; set; }
        public RichTextBox MemoryTextblock { get; set; }

        // Ben Thornhill
        public UVSimModel(int memorySize = 1000)
        {
            MemorySize = memorySize;
            Memory = new List<string>();
            InitializeMemory();
        }

        // Ben Thornhill
        public void InitializeMemory()
        {
            Memory.Clear();

            for (int i = 0; i < MemorySize; i++)
            {
                Memory.Add("0000");
            }
        }
    }
}
