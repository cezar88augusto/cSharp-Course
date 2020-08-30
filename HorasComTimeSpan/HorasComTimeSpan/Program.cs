using System;

namespace HorasComTimeSpan {
    class Program {
        static void Main(string[] args) {

            //DIA, HORA, MINUTO, SEGUNDO, MILISEGUNDO
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t6 = new TimeSpan(1,2,3,4,5);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            //PROPRIEDADES DO TIME SPAN
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days); 
            Console.WriteLine("Hours: " + t.Hours); 
            Console.WriteLine("Minutes: " + t.Minutes); 
            Console.WriteLine("Milliseconds: " + t.Milliseconds); 
            Console.WriteLine("Seconds: " + t.Seconds); 
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays); 
            Console.WriteLine("TotalHours: " + t.TotalHours); 
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); 
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); 
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //OPERACÇÕES COM TIME SPAN

            TimeSpan t10 = new TimeSpan(1, 30, 10); 
            TimeSpan t11 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t10.Add(t11); 
            TimeSpan dif = t10.Subtract(t11); 
            TimeSpan mult = t10.Multiply(2.0); 
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t10); 
            Console.WriteLine(t11); 
            Console.WriteLine(sum); 
            Console.WriteLine(dif); 
            Console.WriteLine(mult); 
            Console.WriteLine(div);
        }
    }
}
