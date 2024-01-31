using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10FinPractice
{
    public interface ILogger
    {
        void Event(string message);

        void Error(string message);
    }
}
