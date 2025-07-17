namespace AsenkronveMultithread.BasicThreading
{
    class ThreadId
    {
        public void ThreadIdMethod()
        {
            Console.WriteLine("Main Thread");
            Console.WriteLine(System.Environment.CurrentManagedThreadId);
            Console.WriteLine(AppDomain.GetCurrentThreadId());
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine(" **** ");

            Thread thread = new(() =>
            {
                Console.WriteLine("Worker 1 Thread");
                Console.WriteLine(System.Environment.CurrentManagedThreadId);
                Console.WriteLine(AppDomain.GetCurrentThreadId());
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine(" **** ");

            Thread thread2 = new(() =>
            {
                Console.WriteLine("Worker 2 Thread");
                Console.WriteLine(System.Environment.CurrentManagedThreadId);
                Console.WriteLine(AppDomain.GetCurrentThreadId());
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine(" **** ");

            Thread thread3 = new(() =>
            {
                Console.WriteLine("Worker 3 Thread");
                Console.WriteLine(System.Environment.CurrentManagedThreadId);
                Console.WriteLine(AppDomain.GetCurrentThreadId());
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });

            thread.Start();
            thread.Join();
            thread2.Start();
            thread2.Join();
            thread3.Start();
            thread3.Join();
        }
    }

}