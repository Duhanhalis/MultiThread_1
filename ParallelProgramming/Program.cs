namespace ParallelProgramming;

class Program
{
    static async Task Main(string[] args)
    {
        // #region Parallel.For
        // Parallel.For(0, 10, (i) =>
        // {
        //     Console.WriteLine($"Task {i}");
        // });
        // #endregion
        // #region Parallel.ForEach
        // List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };

        // Parallel.ForEach(sayilar, sayi =>
        // {
        //     Console.WriteLine($"Sayı {sayi} işleniyor - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        //     // CPU yoğun işlem simülasyonu
        //     for (int i = 0; i < 1000000; i++) { /* hesaplama */ }
        // });

        // Console.WriteLine("Paralel işlem tamamlandı!");
        // Console.ReadLine();
        // #endregion
        // #region Parallel.Invoke
        // Parallel.Invoke(
        //       () => Islem1(),
        //       () => Islem2(),
        //       () => Islem3()
        //   );

        // Console.WriteLine("Tüm işlemler tamamlandı!");
        // Console.ReadLine();
        // #endregion
        // #region Task.WhenAll
        // Task[] tasks = new Task[]
        // {
        //     Task.Run(() => Islem1()),
        //     Task.Run(() => Islem2()),
        //     Task.Run(() => Islem3())
        // };

        // await Task.WhenAll(tasks); // Tüm task'ların tamamlanmasını bekle
        // Console.WriteLine("Tüm işlemler tamamlandı!");
        // #endregion
        #region PLINQ
        // // // Büyük bir veri kümesi oluşturalım
        // int[] sayilar = Enumerable.Range(0, 1000000).ToArray();

        // // PLINQ ile çift sayıları paralel olarak filtreleme
        // var ciftSayilar = sayilar.AsParallel()
        //                          .Where(x => x % 2 == 0)
        //                          .ToList();

        // Console.WriteLine($"Çift sayıların sayısı: {ciftSayilar.Count}");
        // Console.WriteLine("Tamamlandı!");
        // Console.ReadLine();

        // Büyük bir veri kümesi
        // int[] sayilar = Enumerable.Range(0, 20).ToArray();

        // PLINQ ile karekök hesaplama
        // var sonuclar = sayilar.AsParallel()
        //                      .Select(x =>
        //                      {
        //                          Console.WriteLine($"Sayı {x} işleniyor - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        //                          return Math.Sqrt(x);
        //                      })
        //                      .ToList();

        // Console.WriteLine("Karekökler:");
        // sonuclar.ForEach(x => Console.WriteLine(x));
        // Console.ReadLine();
        #endregion
    }


    static void Islem1()
    {
        Console.WriteLine($"İşlem 1 çalışıyor - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        for (int i = 0; i < 1000000; i++) { /* hesaplama */ }
    }

    static void Islem2()
    {
        Console.WriteLine($"İşlem 2 çalışıyor - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        for (int i = 0; i < 1000000; i++) { /* hesaplama */ }
    }

    static void Islem3()
    {
        Console.WriteLine($"İşlem 3 çalışıyor - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        for (int i = 0; i < 1000000; i++) { /* hesaplama */ }
    }
}