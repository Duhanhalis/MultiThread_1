namespace AsenkronveMultithread.BasicThreading
{
    class ThreadClass
    {
        public void ThreadMethod()
        {
            Thread thread = new((o) =>
            {
                for (int i = 0; i < 999; i++)
                {
                    Console.WriteLine($"Worker Thread {i}");
                }
            });
            thread.Start();
            for (int i = 0; i < 999; i++)
            {
                Console.WriteLine($"Main Thread {i}");
            }
            Console.WriteLine("Thread çalıştı");
            
        }
    }
}