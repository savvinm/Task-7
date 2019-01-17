using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LoadLibrary;

namespace IndicatorLibrary
{
    public class Monitor
    {
        public delegate void NewCandleEvent(Candle candle, decimal indicator);
        public event NewCandleEvent NewCandle;
        private Thread Thread { get; set; }
        public Reporter Reporter { get; set; }
        public IIndicator Indicator { get; set; }

        public Monitor(Reporter reporter, IIndicator indicator)
        {
            Reporter = reporter;
            Indicator = indicator;
        }

        public void Run()
        {
            Thread = new Thread(new ThreadStart(Update));
            Thread.Start();
        }

        public void Dispose()
        {
            Thread.Abort();
        }

        private void Update()
        {
            while (Reporter.Candles.Count != 0)
            {
                var candle = Reporter.GetCandle();
                var candle2 = Reporter.GetCandle(5);
                NewCandle?.Invoke(candle, Indicator.Calculate(candle, candle2));
                Thread.Sleep(1000);
            }
        }
    }
}
