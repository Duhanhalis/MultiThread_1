using System.Collections.Concurrent;

namespace AsenkronveMultithread.ThreadSafeCollections;

class ThreadConcurrentQueue
{
    public void ThreadConcurrentQueueMethod()
    {
        // ÖNEMLİ: ConcurrentQueue, thread-safe bir FIFO (First In First Out) koleksiyonudur
        // Elemanların eklenme sırası korunur
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

        // Üretici: Paralel olarak veri ekleme
        Parallel.For(0, 1000, async i =>
        {
            // ÖNEMLİ: Enqueue metodu thread-safe olarak eleman ekler
            // Elemanlar sırayla eklenir ve sırayla çıkarılır (FIFO)
            await Task.Run(() => queue.Enqueue(i));
            Console.WriteLine($"Eklendi: {i} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        });
        Console.WriteLine("Hello world!");
        // Tüketici: Verileri alma
        while (queue.TryDequeue(out int eleman))
        {
            // ÖNEMLİ: TryDequeue metodu thread-safe olarak eleman çıkarır
            // Queue boşsa false döner, eleman varsa true döner ve elemanı out parametresine atar
            Console.WriteLine($"Alındı: {eleman}");
        }

        Console.ReadLine();
    }
}