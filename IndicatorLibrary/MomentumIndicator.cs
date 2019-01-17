using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadLibrary;

namespace IndicatorLibrary
{
    public class MomentumIndicator : IIndicator 
    {
        public MomentumIndicator()
        {

        }
        public decimal Calculate(Candle candle, Candle candle2)
        {
            return candle.Close - candle2.Close;
        }
    }
}
