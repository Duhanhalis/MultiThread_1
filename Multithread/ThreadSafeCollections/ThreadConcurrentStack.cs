using System.Collections.Concurrent;

namespace AsenkronveMultithread.ThreadSafeCollections;

class ThreadConcurrentStack
{
    public void ThreadConcurrentStackMethod()
    {
        // ÖNEMLİ: ConcurrentStack, thread-safe bir LIFO (Last In First Out) koleksiyonudur
        // Son eklenen eleman ilk çıkarılır (stack mantığı)
        ConcurrentStack<int> stack = new ConcurrentStack<int>();

        // Paralel olarak veri ekleme
        Parallel.For(0, 10, i =>
        {
            // ÖNEMLİ: Push metodu thread-safe olarak eleman ekler
            // Elemanlar stack'in en üstüne eklenir
            stack.Push(i);
            Console.WriteLine($"Eklendi: {i} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        });

        // Verileri alma
        while (stack.TryPop(out int eleman))
        {
            // ÖNEMLİ: TryPop metodu thread-safe olarak eleman çıkarır
            // Stack boşsa false döner, eleman varsa true döner ve en üstteki elemanı çıkarır
            Console.WriteLine($"Alındı: {eleman}");
        }

        Console.ReadLine();
    }
}