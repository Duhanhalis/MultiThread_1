namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class AutoResetEventCourse
    {
        public void AutoResetEventMethod()
        {
            #region 1. Örnek
            AutoResetEvent autoResetEvent = new(false);
            int counter = 0;
            Thread thread1 = new(() =>
            {
                while (counter < 10)
                {
                    Console.WriteLine("Thread1 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            Thread thread2 = new(() =>
            {
                autoResetEvent.WaitOne();
                Console.WriteLine("Thread2 : " + counter);
                while (counter < 20 && counter < 30)
                {
                    Console.WriteLine("Thread2 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            Thread thread3 = new(() =>
            {
                autoResetEvent.WaitOne();
                while (counter < 30)
                {
                    Console.WriteLine("Thread3 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        #endregion

        #region 2. Örnek
        public void AutoResetEventMethod2()
        {
            AutoResetEvent autoResetEvent = new(false);
            int counter = 0;
            Thread thread1 = new(() =>
            {
                autoResetEvent.Reset();
                while (counter < 10)
                {
                    Console.WriteLine("Thread1 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            Thread thread2 = new(() =>
            {
                autoResetEvent.Reset();
                autoResetEvent.WaitOne();
                Console.WriteLine("Thread2 : " + counter);
                while (counter < 20 && counter < 30)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Thread2 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            Thread thread3 = new(() =>
            {
                autoResetEvent.Reset();
                autoResetEvent.WaitOne();
                while (counter < 30)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Thread3 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        #endregion

        #region 3. Örnek
        public void AutoResetEventMethod3()
        {
            ManualResetEventSlim autoResetEvent = new(false);
            int counter = 0;
            Thread thread1 = new(() =>
            {
                while (counter < 10)
                {
                    Console.WriteLine("Thread 1 : " + counter);
                    counter++;
                }
                autoResetEvent.Set();
            });
            Thread thread2 = new(() =>
            {
                while (counter < 20)
                {
                    autoResetEvent.Wait();
                    Console.WriteLine("Thread 2 : " + counter);
                    Thread.Sleep(100);
                    counter++;
                    autoResetEvent.Set();
                }
                autoResetEvent.Set();
            });
            Thread thread3 = new(() =>
            {
                while (counter < 30)
                {
                    autoResetEvent.Wait();
                    Console.WriteLine("Thread 3 : " + counter);
                    Thread.Sleep(100);
                    counter++;
                    autoResetEvent.Set();
                }
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        #endregion
    }
}