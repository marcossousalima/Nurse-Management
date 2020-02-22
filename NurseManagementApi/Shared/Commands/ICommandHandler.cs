using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Commands
{
    public interface ICommandHandler<T> where T : ICommandInput
    {
        Task<ICommandExit> Handler(T command);
    }
}
