namespace AsenkronveMultithread.ThreadSafety.Locking
{
   public class ReaderWriterLockSlimCourse
    {
        static ReaderWriterLockSlim readerWriterLockSlim = new();
        static int counter = 0;
        public void Read()
        {
            for (int i = 0; i < 10; i++)

                try
                {
                    readerWriterLockSlim.EnterReadLock();
                    Console.WriteLine($"R : Thread {Thread.CurrentThread.ManagedThreadId} is reading : {counter}");
                }
                finally
                {
                    readerWriterLockSlim.ExitReadLock();
                }
            Thread.Sleep(1000);
        }
        public void Write()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    readerWriterLockSlim.EnterWriteLock();
                    counter++;
                    Console.WriteLine($"W : Thread {Thread.CurrentThread.ManagedThreadId} is writing : {counter}");
                }
                finally
                {
                    readerWriterLockSlim.ExitWriteLock();
                }
                Thread.Sleep(1000);
            }
        }
    }
}