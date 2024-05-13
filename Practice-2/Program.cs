namespace Practice2
{
    internal class Practice2 
    {
        private static void Main(string[] args)
         {
            var practice2 = new Practice2();            
            Thread task1Thread = new Thread(new ThreadStart(practice2.Task1));
            Thread task2Thread = new Thread(new ThreadStart(practice2.Task2));
            task1Thread.Start();
            Thread.Sleep(1000);
            task2Thread.Start();
        }

        internal void Task1() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");

            }
        }

        internal void Task2() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde …");
            }
        }
    }
}