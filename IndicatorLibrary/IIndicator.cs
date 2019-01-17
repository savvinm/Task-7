using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadLibrary;

namespace IndicatorLibrary
{
    public interface IIndicator
    {
        decimal Calculate(Candle candle, Candle candle2);
    }
}
