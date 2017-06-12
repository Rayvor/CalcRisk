using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRisk
{
    class IntWrapper
    {
        public int Value { get; set; }
        public int OldValue { get; set; }
        public IntWrapper(int value, int oldValue) { Value = value; OldValue = oldValue; }
    }
}
