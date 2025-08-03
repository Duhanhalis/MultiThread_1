namespace AsenkronveMultithread.ThreadSafety.Locking
{
    class SpinLockCourse
    {
        public void SpinLockMethod()
        {
            int value = 0;
            SpinLock spinLock = new();
            Thread thread1 = new(() =>
            {
                bool lockTaken = false;
                try
                {
                    spinLock.Enter(ref lockTaken);
                    for (int i = 0; i < 999; i++)
                        Console.WriteLine($"Thread1 : {++value}");
                }
                finally { spinLock.Exit(); }
            });

            Thread thread2 = new(() =>
            {

                bool lockTaken = false;
                try
                {
                    spinLock.Enter(ref lockTaken);
                    for (int i = 0; i < 999; i++)
                        Console.WriteLine($"Thread2 : {--value}");

                }
                finally { spinLock.Exit(); }
            });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }
    }
}
