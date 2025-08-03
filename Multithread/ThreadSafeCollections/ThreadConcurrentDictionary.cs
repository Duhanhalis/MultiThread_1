using System.Collections.Concurrent;

namespace AsenkronveMultithread.ThreadSafeCollections;

class ThreadConcurrentDictionary
{
    public void ThreadConcurrentDictionaryMethod()
    {
        // ÖNEMLİ: ConcurrentDictionary, thread-safe bir dictionary'dir
        // Normal Dictionary'den farklı olarak lock kullanmaz, daha performanslıdır
        ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
        // Paralel olarak veri ekleme
        Parallel.For(0, 10, i =>
        {
            // ÖNEMLİ: TryAdd metodu thread-safe olarak eleman ekler
            // Eğer key zaten varsa false döner, yoksa true döner
            dict.TryAdd(i, $"Değer {i}");
            Console.WriteLine($"Eklendi: {i} -> Değer {i} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(Thread.CurrentThread.ThreadState);
        });

        // Veri okuma
        foreach (var kvp in dict)
        {
            Console.WriteLine($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
        }

        // Güncelleme
        // ÖNEMLİ: AddOrUpdate metodu atomik olarak ekleme veya güncelleme yapar
        // Eğer key yoksa yeni değer ekler, varsa updateFunc ile günceller
        dict.AddOrUpdate(5, "Yeni Değer 5", (key, oldValue) => "Yeni Değer 5");
        Console.WriteLine($"Güncellenmiş değer (5): {dict[5]}");

        // Silme
        // ÖNEMLİ: TryRemove metodu thread-safe olarak eleman siler
        // Silme başarılıysa true döner ve silinen değeri out parametresine atar
        dict.TryRemove(5, out string silinen);
        Console.WriteLine($"Silinen: {silinen}");
    }
}