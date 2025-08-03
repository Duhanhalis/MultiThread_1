namespace AsenkronveMultithread.ThreadSafety.AtomicAndMemory
{
    class VolatileKeyword
    {
        private volatile int i = 0;
        public void VolatileKeywordMethod()
        {
            Thread thread1 = new(() =>
            {
                while (true) { Volatile.Write(ref i, Volatile.Read(ref i) + 1); }
            });

            Thread thread2 = new(() =>
            {
                while (true)
                {
                    Console.WriteLine(Volatile.Read(ref i));
                }
            });

            Thread thread3 = new(() =>
            {
                while (true) { Volatile.Write(ref i, Volatile.Read(ref i) - 1); }
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}