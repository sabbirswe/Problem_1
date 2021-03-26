using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = Convert.ToDateTime(" 2019-08-31 08:59:13");
            DateTime endTime = Convert.ToDateTime(" 2019-08-31 09:00:39");

            Console.WriteLine(CalculateMobileBill(startTime,endTime));
        }


        public static string CalculateMobileBill(DateTime startTime, DateTime endTime)
        {

            double pulseRate = 0;
            double pulse = 20;
            var sTime = startTime.TimeOfDay;
            var eTime = endTime.TimeOfDay;
            var totalSecond = eTime.TotalSeconds - sTime.TotalSeconds;

            var peakHourStart = new TimeSpan(9, 0, 0);
            var peakHourEnd = new TimeSpan(10, 59, 59);
            var firstOffPeakHourStart = new TimeSpan(12, 0, 0);
            var firstOffPeakHourEnd = new TimeSpan(8, 59, 59);


            var secondOffPeakHourStart = new TimeSpan(11, 0, 0);
            var secondOffPeakHourEnd = new TimeSpan(11, 59, 59);


            if (sTime >= peakHourStart & eTime <= peakHourEnd)
            {
                pulseRate = 30;
            }
            else if(sTime >= firstOffPeakHourStart & eTime <= firstOffPeakHourEnd)
            {
                pulseRate = 20;
            }
            else if(sTime >= secondOffPeakHourStart & eTime <= secondOffPeakHourEnd)
            {
                pulseRate = 20;
            }
            else
            {
                pulseRate = 30;
            }
            var total = (totalSecond * pulseRate) / pulse;
            var totalBill = total / 100;

            return String.Format("{0:0.0}", totalBill) +" taka";
        }
    }
}
