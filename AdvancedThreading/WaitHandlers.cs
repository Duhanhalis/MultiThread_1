namespace AsenkronveMultithread
{
    class WaitHandlers
    {
        public void WaitHandlersMethod()
        {
            #region RegisterWaitForSingleObject
            AutoResetEvent autoResetEvent = new(false);

            // RegisterWaitForSingleObject parametreleri:
            // 1. waitObject: Beklenecek WaitHandle nesnesi (autoResetEvent)
            // 2. callBack: Sinyal geldiğinde çağrılacak metod (WorkerMethod)
            // 3. state: Callback metoduna geçirilecek veri ("Task 1 Wait Handle")
            // 4. timeout: Zaman aşımı süresi (-1 = sonsuz bekleme)
            // 5. executeOnlyOnce: Sadece bir kez mi çalıştırılsın (true = evet)
            RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject
            (autoResetEvent, WorkerMethod, "Task 1 Wait Handle", -1, true);

            Thread.Sleep(2500);
            autoResetEvent.Set();

            Console.Read();

        }
        void WorkerMethod(object state, bool timedOut)
        {
            Console.WriteLine($" *** Thread Count : {ThreadPool.ThreadCount}");
            string name = (string)state;
            Console.WriteLine($"{name} işi başladı");
            Thread.Sleep(new Random().Next(1000, 5000));
            Console.WriteLine($"{name} işi tamamlandı");
        }
        #endregion
        public void WaitHandleWaitAllMethod()
        {
            #region WaitHandle. WaitAll
            AutoResetEvent autoResetEvent1 = new(false);
            AutoResetEvent autoResetEvent2 = new(false);
            ManualResetEvent manualResetEvent1 = new(false);
            ManualResetEvent manualResetEvent2 = new(false);

            autoResetEvent1.Set();
            autoResetEvent2.Set();
            manualResetEvent1.Set();
            manualResetEvent2.Set();

            WaitHandle.WaitAll(new WaitHandle[] { autoResetEvent1, autoResetEvent2, manualResetEvent1, manualResetEvent2 });

            Console.WriteLine("Merhaba");
            Console.ReadLine();
            #endregion
        }
         public void WaitHandleWaitAnyMethod()
        {
            #region WaitHandle. WaitAny
            AutoResetEvent autoResetEvent1 = new(false);
            AutoResetEvent autoResetEvent2 = new(false);
            ManualResetEvent manualResetEvent1 = new(false);
            ManualResetEvent manualResetEvent2 = new(false);

            autoResetEvent1.Set();
            autoResetEvent2.Set();
            manualResetEvent1.Set();
            manualResetEvent2.Set();

            WaitHandle.WaitAny(new WaitHandle[] { autoResetEvent1, autoResetEvent2, manualResetEvent1, manualResetEvent2 });

            Console.WriteLine("Merhaba");
            Console.ReadLine();
            #endregion
        }
        public void WaitHandleSignalAndWaitMethod()
        {
            #region WaitHandle. SignalAndWait
            AutoResetEvent autoResetEvent = new(false);
            ManualResetEvent manualResetEvent = new(false);

            WaitHandle.SignalAndWait(autoResetEvent, manualResetEvent);

            Console.WriteLine("Merhaba");
            Console.ReadLine();
            #endregion
        }
    }
}