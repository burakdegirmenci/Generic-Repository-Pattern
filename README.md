# T Generic Repository Pattern ve Entity Framework Core Kullanımı

Bu proje, Entity Framework Core kullanarak ORM (Object Relational Mapping) yapısını ve Generic Repository Pattern'ını uygulayan bir mini projedir.

## ✨ Özellikler

- **🛠 ORM Yapısı**: Entity Framework Core
- **📚 Repository Pattern**: T Generic Repository Pattern
- **🏗 Katmanlı Mimari**: Domain ve Infrastructure katmanları
- **❌ Dependency Injection**: Bu projede Dependency Injection kullanılmamıştır!

## 📂 Proje Yapısı

### 📦 Domain Katmanı

Bu katman, veritabanı varlıklarını (Entities) içerir. Varlık sınıfları burada tanımlanmıştır.

### 🏢 Infrastructure Katmanı

Bu katman, veri erişim işlemlerini ve konfigürasyonları içerir.

#### 🌐 Context

`AppDbContext` sınıfı, Entity Framework Core DbContext sınıfından türetilmiştir ve veritabanı bağlantısını yönetir.

#### Kullanılan Paketler 📦

- `Microsoft.EntityFrameworkCore` (8.0.7)
- `Microsoft.EntityFrameworkCore.SqlServer` (8.0.7)
- `Microsoft.EntityFrameworkCore.Tools` (8.0.7)

