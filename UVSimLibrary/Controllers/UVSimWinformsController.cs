using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UVSimLibrary.Controllers
{
    public class UVSimWinformsController : IUVSimController
    {
        public void FetchUserManual()
        {
            string output = "";

            output += "Welcome to JCB's UV Simulator!\n";
            output += "Please enter instructions one data-word at a time.\n";
            output += "Data words are positve or negative 4 digit strings.\n";
            output += "When you are finished, enter -99999 to stop and run program.\n";
            output += "Please enter commands:\n";

            MessageBox.Show(output);
        }

        public void AcceptUserProgram()
        {

            int memoryLocation = 0;
            string response;

            do // User is still entering commands
            {
                //Keep accepting commands
                Console.Write(memoryLocation + " ? ");
                response = Console.ReadLine();

                string operation = response.Substring(0, 2);
                string operand = response.Substring(2, 2);

                memory.Add(new InputCommandModel { MemoryLocation = memoryLocation++, Operation = operation, Operand = operand });
            } while (response != "9999");



            foreach (var word in memory)
            {
                RunCommand(word.Operation, word.Operand);
                programCounter++;
            }
        }

        private void RunCommand(string operation, string operand)
        {
            //switch (operation)
            //{
            //    case "10":
            //        Read(operand);
            //        break;
            //    case "11":
            //        Write(operand);
            //        break;
            //    case "20":
            //        Load(operand);
            //        break;
            //    case "21":
            //        Store(operand);
            //        break;
            //    case "30":
            //        Add(operand);
            //        break;
            //    case "31":
            //        Subtract(operand);
            //        break;
            //    case "32":
            //        Divide(operand);
            //        break;
            //    case "33":
            //        Multiply(operand);
            //        break;
            //    case "40":
            //        Branch(operand);
            //        break;
            //    case "41":
            //        BranchNeg(operand);
            //        break;
            //    case "42":
            //        BranchZero(operand);
            //        break;
            //    case "43":
            //        Halt();
            //        break;
            //}
        }

        public void DisplayRegisterStats()
        {

        }

        public void DisplayMemory()
        {

        }
    }
}
