using System.Collections.Concurrent;

namespace AsenkronveMultithread.ThreadSafeCollections;

class ThreadBlockingCollection
{
    public void ThreadBlockingCollectionMethod()
    {
        // ÖNEMLİ: BlockingCollection, üretici-tüketici deseninde kullanılır
        // ConcurrentQueue ile birlikte kullanılarak thread-safe bir koleksiyon oluşturur
        // Maksimum 5 eleman kapasitesi ile sınırlandırılmış
        BlockingCollection<int> collection = new BlockingCollection<int>(new ConcurrentQueue<int>(), 5); // Maksimum 5 eleman

        // Üretici
        Task producer = Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                // ÖNEMLİ: Add metodu koleksiyon doluysa otomatik olarak bekler
                collection.Add(i);
                Console.WriteLine($"Üretici: Eklendi {i} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100); // Simüle edilmiş gecikme
            }
            // ÖNEMLİ: CompleteAdding ile üretim bittiğini bildirir, tüketici bunu algılar
            collection.CompleteAdding(); // Üretim bitti
        });

        // Tüketici
        Task consumer = Task.Run(() =>
        {
            // ÖNEMLİ: GetConsumingEnumerable ile koleksiyon boşsa otomatik bekler
            // CompleteAdding çağrıldığında döngü sonlanır
            foreach (int eleman in collection.GetConsumingEnumerable())
            {
                Console.WriteLine($"Tüketici: Alındı {eleman} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(200); // Simüle edilmiş gecikme
            }
        });

        Task.WaitAll(producer, consumer);
        Console.WriteLine("Tamamlandı!");
        Console.ReadLine();
    }
}   