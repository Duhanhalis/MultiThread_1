namespace AsenkronveMultithread
{
    class GetDataAndSetData
    {

        // Thread-local storage için isimli veri slotu oluşturur
        // "x" adında bir slot ayırır ve her thread için ayrı veri saklama alanı sağlar
        LocalDataStoreSlot localDataStoreSlot = Thread.AllocateNamedDataSlot("x");
        // Thread-safe veri erişimi için property tanımı
        // Get: localDataStoreSlot'tan veriyi alır ve int'e çevirir
        // Set: localDataStoreSlot'a değeri kaydeder
        int x { get { return (int?)Thread.GetData(localDataStoreSlot) ?? 0; } set { Thread.SetData(localDataStoreSlot, value); } }
        public void GetDataAndSetDataMethod()
        {   
            x = 0;
            Thread thread1 = new Thread(new ThreadStart(WorkerMethod));
            Thread thread2 = new Thread(new ThreadStart(WorkerMethod));
            thread1.Start();
            thread2.Start();
            Console.Read();
        }
        void WorkerMethod()
        {
            while (x < 10)
            {
                x++;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} x: {x}");
            }
        }
    }
}