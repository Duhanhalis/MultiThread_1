namespace TaskClass;
class Program
{
    static void Main(string[] args)
    {
        // #region 1. Task Class
        // Task task = new Task(new Action(TaskMethod));
        // task.Start();
        // Console.WriteLine("Ana thread biraz iş yapar, sonra bekler.");
        // task.Wait();
        // Console.WriteLine("Ana thread tamamlandı.");
        // Console.WriteLine("Çıkmak için herhangi bir tuşa basın.");
        // #endregion
        // #region 2. Task.Run
        // Task.Run(() =>
        // {
        //     Console.WriteLine("Task.Run metodu başladı.");
        //     Thread.Sleep(3000);
        //     Console.WriteLine("Task.Run metodu bitti.");
        // });
        // #endregion
        // #region 3. Task.Factory.StartNew
        // Task task2 = Task.Factory.StartNew(new Action(TaskMethod));
        // task2.Wait();
        // Console.WriteLine("Ana thread tamamlandı.");
        // Console.WriteLine("Çıkmak için herhangi bir tuşa basın.");
        // #endregion
        // #region 4. Task.ContinueWith
        // Task task3 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // });
        // task3.ContinueWith((_task) =>
        // {
        //     Console.WriteLine("Task.ContinueWith metodu bitti.");
        // });
        // #endregion
        // #region 5. Task.WaitAll
        // Task task4 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 4: {i}");
        //     }
        // });
        // Task task5 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 5: {i}");
        //     }
        // });
        // Task.WaitAll(task4, task5);
        // Console.WriteLine("Task.WaitAll metodu bitti.");
        // #endregion
        // #region 6. Task.WhenAll
        // Task task6 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 6: {i}");
        //     }
        // });
        // Task task7 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 7: {i}");
        //     }
        // });
        // Task.WhenAll(task6, task7);
        // Console.WriteLine("Task.WhenAll metodu bitti.");
        // #endregion
        // #region 7. Task.WaitAny
        // Task task8 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 8: {i}");
        //     }
        // });
        // Task task9 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 9: {i}");
        //     }
        // });
        // Task.WaitAny(task8, task9);
        // Console.WriteLine("Task.WaitAny metodu bitti.");
        // #endregion
        // #region 8. Task.WhenAny
        // Task task10 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 10: {i}");
        //     }
        // });
        // Task task11 = Task.Run(() =>
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine($"Task 11: {i}");
        //     }
        // });
        // Task.WhenAny(task10, task11);
        // Console.WriteLine("Task.WhenAny metodu bitti.");
        // #endregion
        // #region 9. Task.Delay
        // Task task12 = Task.Run(async () =>
        // {
        //     Console.WriteLine("Task 12 başladı.");
        //     await Task.Delay(3000);
        //     Console.WriteLine("Task 12 bitti.");
        // });
        // task12.Wait();
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
        // #region 9. Task.FromCanceled
        // CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        // cancellationTokenSource.Cancel();
        // Task task13 = Task.FromCanceled(cancellationTokenSource.Token);
        // task13.Wait();
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
        // #region 10. Task.FromException
        // Task task14 = Task.Run(() =>
        // {
        //     throw new Exception("Task 14 hatası");
        // });
        // task14.Wait();
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
        // #region 11. Task.FromResult
        // Task<int> task15 = Task.FromResult(10);
        // Console.WriteLine(task15.Result);
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
        // #region 12. Task.GetAwaiter
        // Task<int> task16 = Task.Run(() => 10);
        // var result = task16.GetAwaiter().GetResult();
        // Console.WriteLine(result);
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
        // #region 13. Task.IsCompleted
        // Task task17 = Task.Run(() =>
        // {
        //     Console.WriteLine("Task 17 başladı.");
        // });
        // Console.WriteLine(task17.IsCompleted);
        // #endregion
        // #region 14. Task.CurrentId
        // Task task18 = Task.Run(() =>
        // {
        //     Console.WriteLine($"Task 18 ID: {Task.CurrentId}");
        // });
        // Task task19 = Task.Run(() =>
        // {
        //     Console.WriteLine($"Task 19 ID: {Task.CurrentId}");
        // });
        // Console.WriteLine($"Ana thread ID: {Task.CurrentId}");
        // task18.Wait();
        // task19.Wait();
        // Console.WriteLine("Ana thread bitti.");
        // #endregion
    }

    // static void TaskMethod()
    // {
    //     Console.WriteLine("Task metodu başladı.");
    //     Thread.Sleep(3000);
    //     Console.WriteLine("Task metodu bitti.");
    // }
}