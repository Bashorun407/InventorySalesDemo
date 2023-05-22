using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Common
{
    public interface ILoggerManager
    {
        void LogWarning(string message);
        void LogError(string message);
        void LogDebug(string message);
    }
}
