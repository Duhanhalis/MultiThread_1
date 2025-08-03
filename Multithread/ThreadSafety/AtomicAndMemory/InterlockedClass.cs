namespace AsenkronveMultithread.ThreadSafety.AtomicAndMemory
{
    class InterlockedClass
    {
        public void InterlockedMethod()
        {
            int i = 0;
            var prevalue = Interlocked.Exchange(ref i, 5);
            Console.WriteLine(prevalue);
            Console.WriteLine(i);
            var prevalue2 = Interlocked.CompareExchange(ref i, 10, 0);
            Console.WriteLine(prevalue2);
            Console.WriteLine(i);

            // Thread thread1 = new(() =>
            // {
            //     for (int j = 0; j < 1000; j++)
            //     {
            //         Interlocked.Increment(ref i);
            //     }
            // });

            // Thread thread2 = new(() =>
            // {
            //     while (true)
            //         Console.WriteLine(i);
            // });
            // Thread thread3 = new(() =>
            // {
            //     for (int j = 0; j < 1000; j++)
            //     {
            //         Interlocked.Decrement(ref i);
            //     }
            // });
            // thread1.Start();
            // thread2.Start();
            // thread3.Start();
        }
    }
}