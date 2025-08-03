# 🚀 Asenkron ve Multithread Programlama
---

## 📁 Proje Yapısı

### 🎯 **BasicThreading** - Temel Thread Kavramları
Thread programlamanın temel taşları ve başlangıç konuları

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `ThreadClass.cs` | 🧵 Thread sınıfının temel kullanımı ve thread oluşturma |
| `ThreadId.cs` | 🔢 Thread ID'lerinin yönetimi ve izlenmesi |
| `ThreadCancel.cs` | ❌ Thread iptal işlemleri ve CancellationToken kullanımı |
| `ThreadPoolCourse.cs` | 🏊‍♂️ ThreadPool ile thread havuzu yönetimi |
| `TimerThread.cs` | ⏰ Timer kullanarak zamanlanmış thread işlemleri |

### 🔒 **ThreadSafety** - Thread Güvenliği

#### 📦 **DataStorage** - Thread Veri Depolama
Thread'ler arası güvenli veri paylaşımı ve yerel veri depolama

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `GetData&SetData.cs` | 💾 Thread-local data storage kullanımı |
| `ThreadLocal.cs` | 📌 ThreadLocal<T> ile thread özel veri yönetimi |
| `ThreadStatic.cs` | 🏷️ ThreadStatic attribute ile statik veri yönetimi |

#### 🔐 **Locking** - Kilitleme Mekanizmaları
Thread synchronization ve kilitleme yöntemleri

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `ThreadSafe.cs` | 🛡️ Temel thread safety kavramları |
| `LockIleThreadSafe.cs` | 🔒 Lock statement ile thread güvenliği |
| `MonitorLock.cs` | 👁️ Monitor sınıfı ile kilitleme |
| `ReaderWriterLockSlim.cs` | 📖 Okuma/yazma kilitleri ile performans optimizasyonu |
| `SpinLock.cs` | 🌪️ SpinLock ile yüksek performanslı kilitleme |
| `Spinning.cs` | 🔄 Spin-wait mekanizmaları |

#### 📡 **Signaling** - Sinyal Mekanizmaları
Thread'ler arası iletişim ve senkronizasyon sinyalleri

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `AutoResetEvent.cs` | 🔄 Otomatik sıfırlanan event sinyalleri |
| `CountDownResetEvent.cs` | ⏳ Geri sayım tabanlı event yönetimi |
| `EventWaitHandler.cs` | 📋 Event wait handler kullanımı |
| `ManualResetEventCourse.cs` | ✋ Manuel sıfırlanan event sinyalleri |
| `MutexThread.cs` | 🔐 Mutex ile sistem geneli kilitleme |
| `SemaphoreThread.cs` | 🚦 Semaphore ile kaynak erişim kontrolü |
| `SemaphoreSlim.cs` | 🚦 SemaphoreSlim ile hafif semaphore kullanımı |

#### ⚛️ **AtomicAndMemory** - Atomik ve Bellek Operasyonları
Lock-free programlama ve atomik işlemler

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `InterlockedClass.cs` | ⚡ Interlocked sınıfı ile atomik işlemler |
| `MemoryBarrier.cs` | 🧱 Memory barrier ve bellek sıralaması |
| `SpinWait.cs` | ⏸️ SpinWait ile etkili bekleme |
| `VolatileKeyword.cs` | 💨 Volatile keyword ve bellek optimizasyonu |

### 🎖️ **AdvancedThreading** - İleri Seviye Threading
Kompleks thread yönetimi ve ileri seviye senkronizasyon

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `BarrierThread.cs` | 🚧 Barrier ile thread senkronizasyonu |
| `WaitHandlers.cs` | ⏳ WaitHandle sınıfları ve bekleme mekanizmaları |

### 📦 **ThreadSafeCollections** - Thread Güvenli Koleksiyonlar
Paralel programlama için optimize edilmiş thread-safe veri yapıları

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `ThreadConcurrentQueue.cs` | 📋 FIFO (First In First Out) thread-safe kuyruk |
| `ThreadConcurrentStack.cs` | 📚 LIFO (Last In First Out) thread-safe yığın |
| `ThreadConcurrentBag.cs` | 🎒 Sırasız thread-safe koleksiyon |
| `ThreadConcurrentDictionary.cs` | 📖 Thread-safe anahtar-değer koleksiyonu |
| `ThreadBlockingCollection.cs` | 🚦 Üretici-tüketici deseni için bloke edici koleksiyon |

### ⚡ **ParallelProgramming** - Paralel Programlama
.NET'in paralel programlama araçları ve PLINQ

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `Program.cs` | 🔄 Parallel.For, Parallel.ForEach, Parallel.Invoke, PLINQ örnekleri |

### 🎯 **TaskClass** - Task Programlama Modeli
Modern async/await programlama ve Task sınıfı kullanımı

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `Program.cs` | ⚡ Task.Run, Task.Wait, Task.ContinueWith, Task.WhenAll/WhenAny örnekleri |

### 🏭 **TaskFactory** - Task Fabrikası
TaskFactory ile gelişmiş task yönetimi

| 📄 Dosya | 🎯 Açıklama |
|----------|-------------|
| `Program.cs` | 🏭 TaskFactory.ContinueWhenAll/ContinueWhenAny örnekleri |

## 📖 Öğrenme Hedefleri

Bu projede aşağıdaki konuları öğreneceksiniz:

### 🎯 Temel Konular
- ✅ Thread nedir ve nasıl oluşturulur
- ✅ Thread yaşam döngüsü yönetimi
- ✅ ThreadPool kullanımı ve avantajları
- ✅ Timer ile zamanlanmış işlemler

### 🔒 Thread Güvenliği
- ✅ Race condition nedir ve nasıl önlenir
- ✅ Lock mekanizmaları ve çeşitleri
- ✅ Deadlock durumları ve çözümleri
- ✅ Thread-safe veri yapıları

### 📡 Senkronizasyon
- ✅ Event-based programming
- ✅ Semaphore ve Mutex kullanımı
- ✅ Producer-Consumer pattern
- ✅ Barrier ve koordinasyon

### ⚛️ İleri Seviye
- ✅ Lock-free programming
- ✅ Atomik operasyonlar
- ✅ Memory model ve optimizasyonlar
- ✅ Volatile ve memory barriers

### 📦 Thread-Safe Koleksiyonlar
- ✅ ConcurrentQueue ile FIFO işlemler
- ✅ ConcurrentStack ile LIFO işlemler
- ✅ ConcurrentBag ile sırasız koleksiyonlar
- ✅ ConcurrentDictionary ile thread-safe dictionary
- ✅ BlockingCollection ile üretici-tüketici deseni

### ⚡ Paralel Programlama
- ✅ Parallel.For ile döngü paralelleştirme
- ✅ Parallel.ForEach ile koleksiyon paralelleştirme
- ✅ Parallel.Invoke ile metod paralelleştirme
- ✅ PLINQ ile LINQ sorgularını paralelleştirme

### 🎯 Task Programlama
- ✅ Task.Run ile asenkron işlemler
- ✅ Task.Wait/WhenAll/WhenAny ile senkronizasyon
- ✅ Task.ContinueWith ile zincirleme işlemler
- ✅ CancellationToken ile iptal işlemleri

## 📝 Notlar

- 🎯 Her örnek bağımsız olarak çalıştırılabilir
- 🔍 Kod örnekleri açıklamalı ve anlaşılır
- 🧪 Test edilmiş ve doğrulanmış örnekler
- 📊 Performans karşılaştırmaları mevcut
- 🚀 Modern C# async/await pattern'leri
- ⚡ Paralel programlama optimizasyonları

### 🌟 **Bu proje ile modern C# thread programlamayı öğrenin!** 🌟

[![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Threading](https://img.shields.io/badge/Threading-Advanced-orange.svg)](https://docs.microsoft.com/en-us/dotnet/standard/threading/)
[![Parallel](https://img.shields.io/badge/Parallel-Programming-blue.svg)](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/)
[![Task](https://img.shields.io/badge/Task-Programming-yellow.svg)](https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/)

</div> 