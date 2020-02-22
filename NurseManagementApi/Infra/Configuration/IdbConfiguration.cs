using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuration
{
   public interface IdbConfiguration
    {
        string ConnectionString { get; }
    }
}
