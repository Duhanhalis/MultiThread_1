namespace AsenkronveMultithread.ThreadSafety.Locking
{
    class MonitorLock
    {
        public void MonitorLockMethod()
        {
            object locking = new object();
            Thread thread1 = new(() =>
            {
                var result = Monitor.TryEnter(locking, 3);
                if (result)
                {
                    try
                    {
                        // Monitor.Enter(locking);
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Thread 1 {i}");
                        }
                    }
                    finally
                    {
                        Monitor.Exit(locking);
                    }
                }
            });

            Thread thread2 = new(() =>
            {
                var result = Monitor.TryEnter(locking, 3);
                if (result)
                {
                    try
                    {
                        // Monitor.Enter(locking);
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Thread 2 {i}");
                        }
                    }
                    finally
                    {
                        Monitor.Exit(locking);
                    }
                }
            });
            thread1.Start();
            thread2.Start();
        }
    }
}