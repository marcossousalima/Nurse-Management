using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.Exit
{
   public class CommandExit : ICommandExit
    {
        public CommandExit(bool success, string menssage, object data)
        {
            Success = success;
            Message = menssage;
            Data = data;

        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
