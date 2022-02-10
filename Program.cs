using System;

namespace DatetimeMathMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            */

            /*
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            */

            /*
            Console.WriteLine(DateTime.Now.AddDays(1));
            Console.WriteLine(DateTime.Now.AddHours(3));

            Console.WriteLine(DateTime.Now.ToString("dd")); // 10
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Per
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Perşembe

            Console.WriteLine(DateTime.Now.ToString("mm"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            */

            //Math
            Console.WriteLine(Math.Abs(-13));
            Console.WriteLine(Math.Sin(26));
            Console.WriteLine(Math.Tan(6));
            Console.WriteLine(Math.Cos(2));

            Console.WriteLine(Math.Ceiling(22.3)); //22' den sonra en küçük tam sayı döner
            Console.WriteLine(Math.Round(22.4)); //nereye daha yakınsa -> 0.6'dan büyükse bir sonraki sayıa 
            Console.WriteLine(Math.Floor(22.9)); //herzaman en küçüğü döner

            Console.WriteLine(Math.Pow(3,4)); //3 üzeri 4 = 81
            Console.WriteLine(Math.Sqrt(9)); // karekök alır =3 
            Console.WriteLine(Math.Log(8)); // logaritma

            Console.WriteLine(Math.Exp(3)); //e üzeri  3



        }
    }
}
