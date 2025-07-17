namespace AsenkronveMultithread
{
    class ThreadStatic
    {
        [ThreadStatic]
        static int threadStaticVariable = 0;
        public void ThreadStaticMethod()
        {
            Thread thread1 = new Thread(new ThreadStart(WorkerMethod));
            Thread thread2 = new Thread(new ThreadStart(WorkerMethod));
            thread1.Start();
            thread2.Start();
        }
        void WorkerMethod()
        {
            while (threadStaticVariable < 10)
            {
                threadStaticVariable++;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} threadStaticVariable: {threadStaticVariable}");
            }
        }
    }
}