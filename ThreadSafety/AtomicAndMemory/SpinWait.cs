namespace AsenkronveMultithread.ThreadSafety.AtomicAndMemory
{
    class SpinWaitCourse
    {
        public void SpinWaitMethod()
        {
            bool waitMod = false, condition = false;
            Thread thread1 = new(() =>
            {
                while (!condition)
                {
                    SpinWait.SpinUntil(() =>
                    {
                        Thread.MemoryBarrier();
                        return waitMod || !condition;
                    });
                    Console.WriteLine("Thread1 : " + waitMod);
                }
            });
            thread1.Start();
        }
    }
}