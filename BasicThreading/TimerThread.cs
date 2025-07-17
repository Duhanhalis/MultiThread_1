namespace AsenkronveMultithread
{
    class TimerThread
    {
        public void TimerThreadMethod()
        {
            // Timer oluşturur: WorkerMethod'u callback olarak kullanır, state parametresi null, 
            // 1000ms (1 saniye) gecikme ile başlar, her 100ms'de bir tekrarlar
            Timer timer = new Timer(action =>
            {
                Console.WriteLine("TimerThread çalıştı");
            }, null, 1000, 1000);
            Thread.Sleep(5000);
            timer.Change(0, 500);
            Console.Read();
        }
    }
}