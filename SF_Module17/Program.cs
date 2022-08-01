using System;

namespace SF_Module17
{
    class Program
    {
        // [17.1.5]
        /*
        public static class Constants
        {
            public const string WelcomeString = "Welcome to the forecast page for the";
            public const string ForecastString = "The average temperature expects to be around ";
            public const string LineBreak = "\n";
        }
        */

        static void Main(string[] args)
        {
            // [17.1.5]
            /*
            DailyAverage();
            WeeklyAverage();
            MonthlyAverage();
            */
        }

        // [17.1.4]
        /*
        public String GetDayOfWeek2(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    throw new InvalidOperationException("День недели должен быть в диапазоне 1 to 7");
            }
        }
        */

        // [17.1.5]
        /*
        private static void DailyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} day {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void WeeklyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} week {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void MonthlyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} month {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }
        */
    }
}
