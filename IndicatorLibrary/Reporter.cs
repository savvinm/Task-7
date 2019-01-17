using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadLibrary;

namespace IndicatorLibrary
{
    public class Reporter
    {
        public ILoader Loader { get; private set; }
        public Queue<Candle> Candles { get; private set; }

        public Reporter(ILoader loader)
        {
            this.Loader = loader;
            this.Candles = loader.GetCandles();
        }
        public Candle GetCandle(int n)
        {
            if (Candles.Count >= n)
            {
                List<Candle> candles = Candles.ToList();
                return candles[candles.Count - n];
            }
            return null;
        }
        public Candle GetCandle()
        {
            return this.Candles.Dequeue();
        }

        public void Update()
        {
            this.Candles = this.Loader.GetCandles();
        }
    }
}
