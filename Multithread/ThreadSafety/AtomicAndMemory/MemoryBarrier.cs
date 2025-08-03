namespace AsenkronveMultithread.ThreadSafety.AtomicAndMemory
{
    class MemoryBarrier
    {
        public void MemoryBarrierMethod()
        {
            int i = 0;
            Thread writeThread = new(() =>
            {
                while (true)
                {
                    Thread.MemoryBarrier();
                    Interlocked.Increment(ref i);
                }
            });
            Thread readThread = new(() =>
            {
                while (true)
                {
                    Thread.MemoryBarrier();
                    Console.WriteLine(i);
                }
            });
            writeThread.Start();
            readThread.Start();
            writeThread.Join();
            readThread.Join();
        }
    }
}