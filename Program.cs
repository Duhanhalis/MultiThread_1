using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using AsenkronveMultithread.BasicThreading;
using AsenkronveMultithread.ThreadSafety.Locking;
using AsenkronveMultithread.ThreadSafety.Signaling;
using AsenkronveMultithread.ThreadSafety.AtomicAndMemory;

namespace AsenkronveMultithread
{
    class Program
    {
        static global::System.Threading.Mutex _mutex;
        static string _programName = "Example Project";
        static async Task Main(string[] args)
        {
            // Console.WriteLine("=== ASENKRON ve MULTITHREAD ÖRNEKLERİ ===\n");

            // // === TEMEL THREAD ÖRNEKLERİ ===
            // ThreadClass threadClass = new ThreadClass();
            // //threadClass.ThreadMethod();
            
            // ThreadId threadId = new ThreadId();
            // //threadId.ThreadIdMethod();
            
            // ThreadCancel threadCancel = new ThreadCancel();
            // //threadCancel.ThreadCancelMethod();
            // //await threadCancel.CancellationTokenOrnek();

            // // === THREAD GÜVENLİĞİ ÖRNEKLERİ ===

            // // Locking
            // ThreadSafe threadSafe = new ThreadSafe();
            // //threadSafe.ThreadSafeMethod();
            
            // LockIleThreadSafe lockIleThreadSafe = new LockIleThreadSafe();
            // //lockIleThreadSafe.LockIleThreadSafeMethod();

            // Spinning spinning = new Spinning();
            // //spinning.SpinningMethod();
            
            // MonitorLock monitorLock = new MonitorLock();
            // //monitorLock.MonitorLockMethod();
            
            // ReaderWriterLockSlimCourse readerWriterLockSlimCourse = new();
            // //readerWriterLockSlimCourse.Read();
            // //readerWriterLockSlimCourse.Write();

            // // Signaling
            // MutexThread mutexThread = new MutexThread();
            // // mutexThread.MutexMethod();

            // // Tek program çalıştırma kontrolü
            // if (Mutex.TryOpenExisting(_programName, out _mutex))
            // {
            //     _mutex.Close(); 
            // }
            // else
            // {
            //     _mutex = new(true, _programName);
            //     Console.WriteLine("Program ayakta .... ");
            //     Console.Read();
            // }

            // SemaphoreThread semaphoreThread = new SemaphoreThread();
            // //semaphoreThread.SemaphoreThreadMethod();

            // SemaphoreSlimThread semaphoreSlimThread = new SemaphoreSlimThread();
            // //semaphoreSlimThread.SemaphoreSlimThreadMethod();

            // AutoResetEventCourse autoResetEventCourse = new AutoResetEventCourse();
            // //autoResetEventCourse.AutoResetEventMethod();
            // //autoResetEventCourse.AutoResetEventMethod2();
            // //autoResetEventCourse.AutoResetEventMethod3();

            // EventWaitHandlerCourse eventWaitHandlerCourse = new EventWaitHandlerCourse();
            // //eventWaitHandlerCourse.EventWaitHandlerMethod();
            
            // ManualResetEventCourse manualResetEventCourse = new ManualResetEventCourse();
            // //manualResetEventCourse.ManualResetEventMethod();
            
            // CountDownResetEventCourse countDownResetEventCourse = new CountDownResetEventCourse();
            // //countDownResetEventCourse.CountDownResetEventMethod();
            
            // // Atomic and Memory
            // VolatileKeyword volatileKeyword = new VolatileKeyword();
            // //volatileKeyword.VolatileKeywordMethod();
            
            // InterlockedClass interlockedClass = new InterlockedClass();
            // //interlockedClass.InterlockedMethod();

            // MemoryBarrier memoryBarrier = new MemoryBarrier();
            // //memoryBarrier.MemoryBarrierMethod();

            // SpinWaitCourse spinWaitCourse = new SpinWaitCourse();
            // //spinWaitCourse.SpinWaitMethod();

            // WaitHandlers waitHandlers = new WaitHandlers();
            // //waitHandlers.WaitHandlersMethod();
            // //waitHandlers.WaitHandleWaitAllMethod();

            // ThreadPoolCourse threadPoolCourse = new ThreadPoolCourse();
            // //threadPoolCourse.ThreadPoolMethod();

            BarrierThread barrierThread = new BarrierThread();
            barrierThread.BarrierThreadMethod();

            Console.WriteLine("\nTüm örnekler tamamlandı!");
            Console.Read();
        }
    }
}