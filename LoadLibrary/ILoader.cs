using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadLibrary
{
    public interface ILoader
    {
        Queue<Candle> GetCandles();
    }
}
