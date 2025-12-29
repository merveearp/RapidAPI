🏨 RapidAPI Hotel Project

RapidAPI üzerinden sağlanan otel / konaklama servislerini consume eden, ASP.NET Core .NET 8 ile geliştirilmiş, N-Katmanlı mimariye sahip API ve WebUI projesidir.

==================================================

🎯 Proje Amacı

📌 RapidAPI gibi üçüncü parti servislerin gerçek dünya senaryolarına uygun şekilde consume edilmesi
📌 API ve WebUI katmanlarının birbirinden ayrılması
📌 Kurumsal mimari yaklaşımın .NET 8 üzerinde uygulanması
📌 Sürdürülebilir ve geliştirilebilir bir yapı kurulması

==================================================

🧱 Mimari Yapı (N-Katmanlı)

🟦 Entity Layer
Domain modellerin bulunduğu katman

🟦 DataAccess Layer
Entity Framework Core ve Repository Pattern kullanılan veri erişim katmanı

🟦 Business Layer
İş kuralları ve servis yönetiminin yapıldığı katman

🟦 API Layer
RapidAPI entegrasyonu ve REST servislerin sunulduğu katman

🟦 WebUI Layer
ASP.NET Core MVC tabanlı kullanıcı arayüzü

==================================================

🔗 RapidAPI Entegrasyonu

🔹 Otel arama ve listeleme servisleri consume edilmektedir
🔹 Dış API’den gelen veriler DTO yapıları ile yönetilmektedir
🔹 HttpClient ve async / await yapıları kullanılmaktadır
🔹 API Key bilgileri güvenli şekilde yapılandırılmaktadır

==================================================

🛠️ Kullanılan Teknolojiler

⚙️ ASP.NET Core .NET 8
⚙️ N-Katmanlı Mimari
⚙️ Entity Framework Core
⚙️ Repository Pattern
⚙️ DTO ve AutoMapper
⚙️ RESTful API
⚙️ RapidAPI
⚙️ ASP.NET Core MVC

==================================================

🚧 Proje Durumu

🟡 Bu proje aktif olarak geliştirme aşamasındadır.

📍 Mevcut Durum

✅ RapidAPI entegrasyonu tamamlanmıştır
✅ API ve WebUI katmanları ayrılmıştır
✅ N-Katmanlı mimari yapısı kurulmuştur
✅ Temel otel listeleme senaryoları çalışmaktadır

📍 Planlanan Geliştirmeler

🛎️ Otel arama ve filtreleme özellikleri
🛎️ Otel detay sayfası
🛎️ Rezervasyon akışı
🛎️ Admin panel entegrasyonu
🛎️ Hata yönetimi ve logging mekanizmaları
🛎️ Performans iyileştirmeleri

==================================================

ℹ️ Not

Proje geliştirme süreci devam etmektedir.
Yeni özellikler eklendikçe README içeriği güncellenecektir.

==================================================
