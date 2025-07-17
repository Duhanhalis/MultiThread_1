namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class CountDownResetEventCourse
    {
        public void CountDownResetEventMethod()
        {
            CountdownEvent countdownEvent = new(3);
            int counter = 0;
            object lockObj = new object();

            Thread thread1 = new(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 1 : {++counter}");
                    Thread.Sleep(100);
                }
                countdownEvent.Signal();
            });

            Thread thread2 = new(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 2 : {++counter}");
                    Thread.Sleep(100);
                }
                countdownEvent.Signal();
            });

            Thread thread3 = new(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread 3 : {++counter}");
                    Thread.Sleep(100);
                }
                countdownEvent.Signal();
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();

            countdownEvent.Wait();
            Console.WriteLine("Thread'lerin işlemleri bitmiştir ... ");
        }
    }
}