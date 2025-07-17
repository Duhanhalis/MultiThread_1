namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class ManualResetEventCourse
    {
        public void ManualResetEventMethod()
        {
            ManualResetEventSlim manualResetEventSlim = new(false);
            int counter = 0;
            object lockObj = new object();

            Thread thread1 = new(() =>
            {
                while (true)
                {
                    if (counter >= 10) break;
                    Console.WriteLine($"Thread 1 : {++counter}");
                    Thread.Sleep(100);
                }
                manualResetEventSlim.Set();
            });

            Thread thread2 = new(() =>
            {
                manualResetEventSlim.Wait();
                while (true)
                {
                    if (counter >= 20) break;
                    Console.WriteLine($"Thread 2 : {++counter}");
                    Thread.Sleep(100);
                }
            });

            Thread thread3 = new(() =>
            {
                manualResetEventSlim.Wait();
                while (true)
                {

                    if (counter >= 30) break;
                    Console.WriteLine($"Thread 3 : {++counter}");
                }
                Thread.Sleep(100);
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
        }
    }
}