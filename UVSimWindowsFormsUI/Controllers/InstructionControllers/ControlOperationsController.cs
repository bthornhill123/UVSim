using System;
using System.Collections.Generic;
using System.Text;
using UVSimWindowsFormsUI.Models;

namespace UVSimWindowsFormsUI.Controllers.InstructionControllers
{
    public static class ControlOperationsController
    {
        //Control Operations
        //using op -1 because after the command runs the pc will be incremented by 1
        public static void Branch(this UVSimModel uvSim, string operand)
        {
            //pc = operand - 1;
        }
        public static void BranchNeg(this UVSimModel uvSim, string operand)
        {
            //if (accumulator < 0)
            //{
            //    //pc = operand - 1;
            //}
        }
        public static void BranchZero(this UVSimModel uvSim, string operand)
        {
            //if (accumulator == 0)
            //{
            //    //pc = operand - 1;
            //}
        }
        public static void Halt(this UVSimModel uvSim)
        {
           // pc = 101;
        }
    }
}
