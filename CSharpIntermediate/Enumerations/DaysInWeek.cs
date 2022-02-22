using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Enumerations
{
    public enum DaysInWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    public enum DaysInWeek2
    {
        Monday = 10, 
        Tuesday = 20,
        Wednesday = 35,
        Thursday = 48,
        Friday = 74,
        Saturday = 12,
        Sunday = 154
    }
    // change default int type to short
    public enum DaysInWeek3 : short 
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
