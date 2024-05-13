
namespace Practice1
{
    internal class Practice1 
    {
        private static void Main(string[] args)
        {
            var practice1 = new Practice1();            
            Thread task1Thread = new Thread(new ThreadStart(practice1.Task1));
            task1Thread.Start();
        }

        internal void Task1() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }
    }
}