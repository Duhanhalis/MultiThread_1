namespace AsenkronveMultithread.ThreadSafety.Locking
{
    class Spinning
    {
        public void SpinningMethod()
        {
            bool threadCondition = true;
            Thread thread1 = new(() =>
            {
                while (true)
                {
                    if (!threadCondition)
                    {

                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine($"Thread 1 {i}.");
                        threadCondition = false;
                        break;
                    }
                }
            });

            Thread thread2 = new(() =>
            {
                while (true)
                {
                    if (threadCondition)
                    {
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine($"Thread 2 {i}.");
                        threadCondition = false;
                        break;
                    }
                }
            });
            
            thread1.Start();
            thread2.Start();
          

        }
    }
}