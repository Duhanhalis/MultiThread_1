using System.Threading;

namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class MutexThread
    {
        public void MutexMethod()
        {
            global::System.Threading.Mutex mutex = new();
            Thread thread1 = new(() =>
            {
                mutex.WaitOne();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 1 {i}");
                }
                mutex.ReleaseMutex();
            });
            Thread thread2 = new(() =>
            {
                mutex.WaitOne();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 2 {i}");
                }
                mutex.ReleaseMutex();
            });
            thread1.Start();
            thread2.Start();
        }
    }
}
