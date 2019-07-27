using System;
using System.Collections.Generic;
using System.Text;
using UVSimLibrary.Models;

namespace UVSimLibrary.Controllers
{
    public class WinformsHelperController
    {
        public List<OperationModel> GetAvailableOperations()
        {
            List<OperationModel> output = new List<OperationModel>();

            output.Add(new OperationModel { Name = "Read", OpCode = "10" });
            output.Add(new OperationModel { Name = "Write", OpCode = "11" });
            output.Add(new OperationModel { Name = "Load", OpCode = "20" });
            output.Add(new OperationModel { Name = "Store", OpCode = "21" });
            output.Add(new OperationModel { Name = "Add", OpCode = "30" });
            output.Add(new OperationModel { Name = "Subtract", OpCode = "31" });
            output.Add(new OperationModel { Name = "Divide", OpCode = "32" });
            output.Add(new OperationModel { Name = "Multiply", OpCode = "33" });
            output.Add(new OperationModel { Name = "Branch", OpCode = "40" });
            output.Add(new OperationModel { Name = "BranchNeg", OpCode = "41" });
            output.Add(new OperationModel { Name = "BranchZero", OpCode = "42" });
            output.Add(new OperationModel { Name = "Halt", OpCode = "43" });

            return output;
        }
    }
}
