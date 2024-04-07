using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace BookingDashboardWPF
{
    public class Prenotazioni
    {
        public ISeries[] Series { get; set; }

        public ISeries[] AnotherSeries { get; set; }

        public double Statistica1 { get; set; }

        public double Statistica2 { get; set; }

        public Prenotazioni()
        {
            
            Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new List<double> { 0, 1, 2 }
                },
                new ColumnSeries<double>
                {
                    Values = new List<double> { 2, 3, 4 }
                }
            };

            AnotherSeries = new ISeries[]
            {
                    new PieSeries<double> { Values = new double[] { 2 } },
                    new PieSeries<double> { Values = new double[] { 4 } },
                    new PieSeries<double> { Values = new double[] { 1 } },
                    new PieSeries<double> { Values = new double[] { 3 } }
            };

            Statistica1 = 0;

            Statistica2 = 0;
        }

        public void Aggiorna()
        {
            var r = new Random();

            var valuesLines = Series[0].Values as List<double>;
            valuesLines.Clear();
            for (int i = 0; i < 5; i++)
            {
                valuesLines.Add(r.Next(0, 10));
            }

            var valuesColumns = Series[1].Values as List<double>;
            valuesColumns.Clear();
            for (int i = 0; i < 5; i++)
            {
                valuesColumns.Add(r.Next(0, 10));
            }
            
            foreach (var item in AnotherSeries)
            {
                var pieSeries = item as PieSeries<double>;
                pieSeries.Values = new double[] { r.NextDouble() * 100 };
            }

            Statistica1 = r.NextDouble() * 100;

            Statistica2 = r.NextDouble() * 100;
        }
    }
}
