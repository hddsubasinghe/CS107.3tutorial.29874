using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial02q3
{
    class TemperatureTracker
    {
        private double[] weeklyTemperatures;

        public TemperatureTracker(int daysInWeek)
        {
            weeklyTemperatures = new double[daysInWeek];
        }

        public void InputTemperatures()
        {
            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    weeklyTemperatures[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature.");
                    i--; // Retry input for the same day
                }
            }
        }

        public void DisplayWeeklyReport()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {weeklyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            const int DaysInWeek = 7;

            TemperatureTracker temperatureTracker = new TemperatureTracker(DaysInWeek);

            Console.WriteLine("Enter temperatures for the week:");
            temperatureTracker.InputTemperatures();

            temperatureTracker.DisplayWeeklyReport();
        }
    }
        
        }
    

