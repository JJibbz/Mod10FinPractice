using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10FinPractice
{
    public class Calc : ICalc
    {
        ILogger Logger { get; }
        public Calc(ILogger logger)
        {
            Logger = logger;
        }
        public int Sum(int a, int b)
        {
            Logger.Event("Складываем...");
            Thread.Sleep(3000);
            Logger.Event("Результат сложения:");
            return a + b;
            

        }
    }
}
