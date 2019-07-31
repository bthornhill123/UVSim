using System;
using System.Collections.Generic;
using System.Text;
using UVSimWindowsFormsUI.Models;

namespace UVSimWindowsFormsUI.Controllers.InstructionControllers
{
    public static class ControlOperationsController
    {
        //Control Operations
        //Jaren Flaker
        public static void Branch(this UVSimModel uvSim, string operand)
        {
            uvSim.ProgramCounter = int.Parse(operand);
        }
        //Jaren Flaker
        public static void BranchNeg(this UVSimModel uvSim, string operand)
        {
            if(uvSim.Accumulator < 0)
            {
                uvSim.ProgramCounter = int.Parse(operand);
            }

        }
        //Jaren Flaker
        public static void BranchZero(this UVSimModel uvSim, string operand)
        {
            if (uvSim.Accumulator == 0)
            {
               uvSim.ProgramCounter = int.Parse(operand);
            }
        }
        //Jaren Flaker
        public static void Halt(this UVSimModel uvSim)
        {
            uvSim.ProgramCounter = -666;
            
        }
    }
}
