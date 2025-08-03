namespace AsenkronveMultithread
{
    class ThreadLocal
    {
        static ThreadLocal<int> threadLocalVariable = new ThreadLocal<int>(() => 0);
        public void ThreadLocalMethod()
        {
            Thread thread1 = new Thread(new ThreadStart(WorkerMethod));
            Thread thread2 = new Thread(new ThreadStart(WorkerMethod));
            Thread thread3 = new Thread(new ThreadStart(WorkerMethod));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        void WorkerMethod()
        {
            while (threadLocalVariable.Value < 10)
            {
                threadLocalVariable.Value++;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} threadLocalVariable: {threadLocalVariable.Value}");
            }
        }
    }
}