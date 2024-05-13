using System.Diagnostics;

namespace Assignment1 
{
    internal class Assignment1 
    {
        private static void Main(string[] args) 
        {
            Assignment1 assignment1 = new Assignment1();
            Thread tempGen = new Thread(new ThreadStart(assignment1.TempGen));
            tempGen.Priority = ThreadPriority.BelowNormal;
            tempGen.Start();

            while (true) 
            {
                Thread.Sleep(10000);
                
                if (!tempGen.IsAlive)
                {
                    Console.WriteLine("Alarm thread terminated.");
                    Environment.Exit(0);
                }
            }
        }

        internal void TempGen() 
        {
            sbyte temp;
            sbyte minTemp = 0;
            sbyte maxTemp = 100;
            byte amountAlarmsTriggered = 1;
            byte maxAlarmTriggers = 3;

            Random randomTemp = new Random();

            while(true) 
            {
                Thread.Sleep(2000);
                temp = (sbyte)randomTemp.Next(-20,121);
                Console.WriteLine(temp);
                if(minTemp > temp || maxTemp <= temp)
                {
                    Console.WriteLine("Alarm: the temperature has gone into invalid range!");
                    
                    amountAlarmsTriggered++;
                }
                if (amountAlarmsTriggered > maxAlarmTriggers) 
                {
                        break;
                }
            }
        }
    }
}