using System;
using System.Collections.Generic;
using System.Text;
using UVSimConsoleUI.Models;

namespace UVSimConsoleUI
{
    public static class Interpreter
    {
        public static void RunCommand(List<WordModel> memory, string operation, string operand)
        {
            switch (operation)
            {
                case "10":
                    Read(operand, memory);
                    break;
                default:
                    break;
            }
        }

        public static void Read(string operand, List<WordModel> memory)
        {

        }

    }
}
