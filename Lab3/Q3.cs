//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3
//{
//    class TemparatureTracker
//    {
//        private int[] temperatures = {0,0,0,0,0,0,0 };

//        public void SetTemperature(int ind, int temp)
//        {
//            temperatures[ind] = temp;
//        }

//        public void DisplayTemperature()
//        {
//            Console.WriteLine("Weekly Temperature: ");
//            for (int i = 0; i < temperatures.Length; i++)
//            {
//                Console.WriteLine(" " + temperatures[i]);
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TemparatureTracker newtracker = new TemparatureTracker();

//            for (int i = 0; i < 7; i++)
//            {
//                Console.Write("Enter temperature: ");
//                int value = Convert.ToInt32(Console.ReadLine());
//                newtracker.SetTemperature(i, value);
//            }

//            newtracker.DisplayTemperature();
//            Console.ReadLine();
//        }
//    }
//}
