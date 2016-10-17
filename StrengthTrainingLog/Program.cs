using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingLog
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingLog log = new TrainingLog();
            log.AddSession("24 hr fitness kettlebell session");
            log.AddSession("Home Yoga Session in da basement");
        }
    }
}
