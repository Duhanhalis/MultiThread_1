using System.Collections.Concurrent;

namespace AsenkronveMultithread.ThreadSafeCollections;

class ThreadConcurrentBag
{
    // Tanım: Sırasız bir veri koleksiyonudur. Elemanların sırası garanti edilmez, bu yüzden hızlı ekleme ve alma işlemleri için uygundur.
    public void ThreadConcurrentBagMethod()
    {
        // ÖNEMLİ: ConcurrentBag, thread-safe bir koleksiyondur
        // Elemanların sırası garanti edilmez, hızlı ekleme/çıkarma için optimize edilmiştir
        ConcurrentBag<int> bag = new ConcurrentBag<int>();

        // Paralel olarak veri ekleme
        Parallel.For(0, 10, i =>
        {
            // ÖNEMLİ: Add metodu thread-safe olarak çalışır
            // Her thread kendi local queue'una ekler, bu yüzden çok hızlıdır
            bag.Add(i);
            Console.WriteLine($"Eklendi: {i} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        });

        Console.WriteLine($"Toplam eleman: {bag.Count}");
        Console.WriteLine("Elemanlar: " + string.Join(", ", bag));

        // Eleman alma
        while (bag.TryTake(out int eleman))
        {
            // ÖNEMLİ: TryTake metodu thread-safe olarak eleman çıkarır
            // Eleman yoksa false döner, varsa true döner ve elemanı out parametresine atar
            Console.WriteLine($"Alındı: {eleman}");
        }

        Console.ReadLine();
    }
}