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

            // TODO - Fill these in with all of the 
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });
            output.Add(new OperationModel { Name = "", OpCode = "" });

            return output;
        }
    }
}
