namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class SemaphoreSlimThread
    {
        public void SemaphoreSlimThreadMethod()
        {
            SemaphoreSlim semaphoreSlim = new(2, 3);
            Thread thread1 = new(() =>
            {
                semaphoreSlim.Wait(100);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 1 : {i}");
                    // Thread.Sleep(1000);
                }
                semaphoreSlim.Release();
            });
            Thread thread2 = new(() =>
            {
                semaphoreSlim.Wait(1000);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 2 : {i}");
                    // Thread.Sleep(1000);
                }
                semaphoreSlim.Release();
            });
            Thread thread3 = new(() =>
            {
                semaphoreSlim.Wait(1000);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 3 : {i}");
                    // Thread.Sleep(1000);
                }
                semaphoreSlim.Release();
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}