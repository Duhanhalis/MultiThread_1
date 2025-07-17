# 🚀 Asenkron ve Multithread Programlama

## 📚 Kurs Hakkında

> **Gençay Yıldız : Asenkron ve Multithread Programlama Eğitimi - 1. Etap** kursunun eğitim özeti ve uygulama örnekleridir.

Bu proje, C# dilinde asenkron programlama ve çoklu thread yönetimi konularında kapsamlı örnekler içermektedir. Modern yazılım geliştirmede kritik öneme sahip bu konuları teorik bilgi ile pratik uygulamaları birleştirerek öğrenebilirsiniz.

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

---

## 🛠️ Kurulum ve Çalıştırma

### 📋 Gereksinimler
- .NET 9.0 SDK
- Visual Studio 2022 veya VS Code
- C# 12.0

### 🚀 Proje Çalıştırma

```bash
# Proje dizinine gidin
cd AsynchronousAndMultithread

# Projeyi derleyin
dotnet build

# Projeyi çalıştırın
dotnet run
```

---

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

---

## 🎓 Kurs İçeriği

Bu proje **Gençay Yıldız**'ın **Asenkron ve Multithread Programlama Eğitimi**nin 1. etap materyallerini içermektedir.

### 📚 Eğitim Modülleri

1. **🧵 Thread Temelleri** - Thread kavramı ve temel kullanım
2. **🔒 Thread Safety** - Güvenli thread programlama
3. **📡 Senkronizasyon** - Thread'ler arası iletişim
4. **⚛️ Atomik İşlemler** - Lock-free programlama
5. **🎖️ İleri Seviye** - Kompleks senkronizasyon senaryoları

---

## 🔗 Faydalı Bağlantılar

- 📖 [Microsoft Threading Documentation](https://docs.microsoft.com/en-us/dotnet/standard/threading/)
- 🎥 [Gençay Yıldız YouTube Kanalı](https://www.youtube.com/playlist?list=PLQVXoXFVVtp1wcNcTWS1GlC0r4ItcQvAj)
- 💡 [.NET Threading Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/threading/managed-threading-best-practices)

---

## 📝 Notlar

- 🎯 Her örnek bağımsız olarak çalıştırılabilir
- 🔍 Kod örnekleri açıklamalı ve anlaşılır
- 🧪 Test edilmiş ve doğrulanmış örnekler
- 📊 Performans karşılaştırmaları mevcut

---

<div align="center">

### 🌟 **Bu proje ile modern C# thread programlamayı öğrenin!** 🌟

[![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Threading](https://img.shields.io/badge/Threading-Advanced-orange.svg)](https://docs.microsoft.com/en-us/dotnet/standard/threading/)

</div> 