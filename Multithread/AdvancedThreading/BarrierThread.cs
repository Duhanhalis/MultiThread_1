namespace AsenkronveMultithread
{
    class BarrierThread
    {
        static Barrier barrier = new(3, (b) =>
        {
            Console.WriteLine($"Barrier işlemi tamamlandı. Thread sayısı: {b.ParticipantCount}");
        });
        public void BarrierThreadMethod()
        {
            Thread thread1 = new(new ThreadStart(WorkerMethod));
            Thread thread2 = new(new ThreadStart(WorkerMethod));
            Thread thread3 = new(new ThreadStart(WorkerMethod));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        void WorkerMethod()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} başladı");
            barrier.SignalAndWait();
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} tamamlandı");
        }
    }
}