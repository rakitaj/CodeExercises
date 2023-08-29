using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.Algorithms
{
    public class ByteConversions
    {
        public static int[] FromInteger(int value, int? length = null)
        {
            var bitsPower = (int)Math.Max(0, Math.Log2(value));
            var bitArrayLength = length ?? bitsPower + 1;
            var bits = new int[bitArrayLength];
            for (int i = bitsPower; i >= 0; i--)
            {
                int divisor = (int)Math.Pow(2, i);
                var (quotient, remainder) = Math.DivRem(value, divisor);
                bits[i] = quotient;
                value = remainder;
            }
            return bits;
        }
    }
}
