using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsenkronveMultithread.ThreadSafety.Locking
{
    public class LockIleThreadSafe
    {
        public void LockIleThreadSafeMethod()
        {
            List<int> list = new List<int>();
            int sayac = 0;
            object kilit = new object(); // Lock objesi

            Parallel.For(0, 1000, i =>
            {
                lock (kilit) // ✅ Aynı anda sadece bir thread girebilir
                {
                    list.Add(i); // Artık güvenli
                    sayac++; // Artık güvenli
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : {i}");
                }
            });

            Console.WriteLine($"✅ Liste eleman sayısı: {list.Count}");
            Console.WriteLine($"✅ Sayaç değeri: {sayac}");
            Console.WriteLine("Lock sayesinde her zaman doğru sonuç!");
        }
    }
} 