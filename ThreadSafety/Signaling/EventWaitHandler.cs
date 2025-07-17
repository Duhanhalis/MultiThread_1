namespace AsenkronveMultithread.ThreadSafety.Signaling
{
    class EventWaitHandlerCourse
    {
        public void EventWaitHandlerMethod()
        {
            EventWaitHandle resetEvent = new(false, EventResetMode.AutoReset);
            EventWaitHandle resetEvent2 = new(false, EventResetMode.ManualReset);

            int counter = 0;
            #region AutoReset
            // Thread thread1 = new(() =>
            // {
            //     while (counter < 10)
            //     {
            //         Thread.Sleep(100);
            //         Console.WriteLine($"Thread 1 : {++counter}");
            //     }
            //     resetEvent.Set();
            // });

            // Thread thread2 = new(() =>
            // {
            //     resetEvent.WaitOne();
            //     while (counter < 20)
            //     {
            //         Thread.Sleep(100);
            //         Console.WriteLine($"Thread 2 : {++counter}");

            //         resetEvent.Set();
            //     }
            // });

            // Thread thread3 = new(() =>
            // {
            //     resetEvent.WaitOne();
            //     while (counter++ < 30)
            //     {
            //         Thread.Sleep(100);
            //         Console.WriteLine($"Thread 3 : {counter}");
            //     }
            // });

            // thread1.Start();
            // thread2.Start();
            // thread3.Start();
            #endregion
            #region ManualReset
            Thread thread1 = new(() =>
            {
                while (counter < 10)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"Thread 1 : {++counter}");
                }
                resetEvent2.Set();
            });

            Thread thread2 = new(() =>
            {
                resetEvent2.WaitOne();
                while (counter < 20)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"Thread 2 : {++counter}");

                    resetEvent2.Set();
                }
            });

            Thread thread3 = new(() =>
            {
                resetEvent2.WaitOne();
                while (counter++ < 30)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"Thread 3 : {counter}");
                }
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
            #endregion
        }
    }
}