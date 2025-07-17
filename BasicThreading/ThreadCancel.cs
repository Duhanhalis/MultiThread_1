namespace AsenkronveMultithread.BasicThreading
{
    public class ThreadCancel
    {
        public void ThreadCancelMethod()
        {
            bool shouldStop = false;
            Thread thread = new(() =>
            {

                while (!shouldStop)
                {
                    Console.WriteLine("Thread çalışıyor!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Thread ișlemi sona erdi.");
            });

            thread.Start();
            Thread.Sleep(5000);
            shouldStop = true;
        }
        public async Task CancellationTokenOrnek()
        {
            using (var cts = new CancellationTokenSource())
            {
                // 3 saniye sonra iptal et
                cts.CancelAfter(3000);

                try
                {
                    await UzunIslemIptalEdilir(cts.Token);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("İşlem iptal edildi!");
                }
            }
        }

        public async Task UzunIslemIptalEdilir(CancellationToken cancellationToken)
        {
            Console.WriteLine("Uzun işlem başladı... (3 saniye sonra iptal edilecek)");

            for (int i = 0; i < 10; i++)
            {
                // İptal kontrolü
                cancellationToken.ThrowIfCancellationRequested();

                Console.WriteLine($"  Adım {i + 1}/10");
                await Task.Delay(1000, cancellationToken);
            }

            Console.WriteLine("Uzun işlem tamamlandı!");
        }
    }
}