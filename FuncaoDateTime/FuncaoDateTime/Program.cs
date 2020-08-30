using System;
using System.Globalization;

namespace FuncaoDateTime {
    class Program {
        static void Main(string[] args) {

            //Hora do Sistema
            DateTime d1 = new DateTime(2000, 8, 15); // DIA + MêS + ANOS
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); // DIA + MêS + ANOS + MINUTOS + SEGUNDOS
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); // DIA + MêS + ANOS + MINUTOS + SEGUNDOS + MILISEGUNDOS

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now; // Data Atual
            DateTime d5 = DateTime.UtcNow; //Horário universal
            DateTime d6 = DateTime.Today; //Data de Hoje sem hora

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            //CONVERTENDO DATAS
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            //CONSTRUINDO AS MASCARAS
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);

            //PROPRIEDADES DO DATE TIME

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);

            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            //CONVERTER O DATE TIME

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = x.ToLongDateString();
            string s2 = x.ToLongTimeString();
            string s3 = x.ToShortDateString();
            string s4 = x.ToShortTimeString();
            string s5 = x.ToString();
            string s6 = x.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = x.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            // OPERAÇÕES COM DATE TIME

            DateTime y = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime x1 = y.AddDays(2);
            DateTime x2 = x.AddHours(2);
            DateTime x3 = x.AddMilliseconds(2);
            DateTime x4 = x.AddMinutes(2);
            DateTime x5 = x.AddMonths(2);
            DateTime x6 = x.AddSeconds(2);
            DateTime x7 = x.AddTicks(2L);
            DateTime x8 = x.AddYears(2);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            Console.WriteLine(x6);
            Console.WriteLine(x7);
            Console.WriteLine(x8);

            //DIFERENÇA ENTRE DATAS

            DateTime data1 = new DateTime(2020, 8, 6);
            DateTime data2 = new DateTime(2021, 1, 14);

            data1.Subtract(data2);

            // A diferença será um TimeSpan:

            TimeSpan diferenca = data1.Subtract(data2);

            Console.WriteLine(diferenca.TotalDays);




        }
    }
}
