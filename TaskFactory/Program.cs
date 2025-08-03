using System.Threading.Tasks;

namespace TaskFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            //     #region TaskFactory.ContinueWhenAll
            //    Task task1 = Task.Run(() =>
            //    {
            //     for(int i = 0; i < 10; i++)
            //     {
            //         Console.WriteLine($"Task 1: {i}");
            //     }
            //    });
            //    Task task2 = Task.Run(() =>
            //    {
            //     for(int i = 0; i < 10; i++)
            //     {
            //         Console.WriteLine($"Task 2: {i}");
            //     }
            //    });
            //    TaskFactory taskFactory = new TaskFactory();
            //    taskFactory.ContinueWhenAll(new Task[] { task1, task2 }, (tasks) =>
            //    {
            //     Console.WriteLine("Tasklar bitti.");
            //    });
            //    Console.WriteLine("Ana thread bitti.");
            //    #endregion
        //     #region TaskFactory.ContinueWhenAny
        //     Task task1 = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"Task 1: {i}");
        //        }
        //    });
        //     Task task2 = Task.Run(() =>
        //     {
        //         for (int i = 0; i < 10; i++)
        //         {
        //             Console.WriteLine($"Task 2: {i}");
        //         }
        //     });
        //     TaskFactory taskFactory2 = new TaskFactory();
        //     taskFactory2.ContinueWhenAny(new Task[] { task1, task2 }, (task) =>
        //     {
        //         Console.WriteLine("Tasklar bitti.");
        //     });
        //     Console.WriteLine("Ana thread bitti.");
        //     #endregion
        }
    }
}