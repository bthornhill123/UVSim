using System;
using System.Collections.Generic;
using System.Text;
using UVSimConsoleUI.Models;

namespace UVSimConsoleUI
{
    public static class UVSim
    {
        public static void DisplayUserManual()
        {
            Console.WriteLine("WElcome to the program");
        }

        public static void AcceptUserProgram()
        {
            Console.WriteLine("Please enter commands:");

            List<WordModel> memory = new List<WordModel>();

            int memoryLocation = 0;
            string response;

            do // still user is still entering commands
            {
                // Keep accepting commands
                Console.Write(memoryLocation + " ? ");
                response = Console.ReadLine();

                string operation = response.Substring(0, 2);
                string operand = response.Substring(2, 2);

                memory.Add(new WordModel { MemoryLocation = memoryLocation++, Operation = operation, Operand = operand });
            } while (response != "9999");



            foreach (var word in memory)
            {
                Interpreter.RunCommand(memory, word.Operation, word.Operand);
            }
        }

     

        public static void DisplayRegisterStats()
        {

        }

        public static void DisplayMemory()
        {

        }

    }
}
