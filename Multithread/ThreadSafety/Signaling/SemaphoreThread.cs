namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class SemaphoreThread
    {
        public void SemaphoreThreadMethod()
        {
            List<int> numbers = new();
            Semaphore semaphore = new(3, 3);
            Thread thread1 = new(() =>
{
    semaphore.WaitOne();
    int i = 0;
    while (i < 10)
    {

        Console.WriteLine($"Thread 1 : {++i}");
        numbers.Add(i);
        Thread.Sleep(1000);
    }

    semaphore.Release();
});
            Thread thread2 = new(() =>
{
    semaphore.WaitOne();
    int i = 10;
    while (i < 20)
    {
        Console.WriteLine($"Thread 2 : {++i}");
        numbers.Add(i);
        Thread.Sleep(1500);
    }

    semaphore.Release();
});
            thread1.Start();
            thread2.Start();
        }
    }
}