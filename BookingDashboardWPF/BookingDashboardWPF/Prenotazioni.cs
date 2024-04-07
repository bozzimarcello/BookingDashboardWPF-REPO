using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BookingDashboardWPF
{
    public class Prenotazioni
    {
        public ISeries[] Series { get; set; }

        public ISeries[] AnotherSeries { get; set; }

        public Prenotazioni()
        {
            List<double> values = new List<double> { 0, 1, 2 };
            Series = new ISeries[1];
            Series[0] = new LineSeries<double>
            {
                Values = values
            };

            AnotherSeries = new ISeries[]
            {
                    new PieSeries<double> { Values = new double[] { 2 } },
                    new PieSeries<double> { Values = new double[] { 4 } },
                    new PieSeries<double> { Values = new double[] { 1 } },
                    new PieSeries<double> { Values = new double[] { 3 } }
            };
        }

        public void Aggiorna()
        {
            var r = new Random();
            var values = Series[0].Values as List<double>;
            values.Clear();
            for (int i = 0; i < 5; i++)
            {
                values.Add(r.Next(0, 10));
            }
        }
    }
}
