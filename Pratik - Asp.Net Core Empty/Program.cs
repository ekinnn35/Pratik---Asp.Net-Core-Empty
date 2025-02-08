var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot içindeki statik dosyaları kullanabilmesini sağla
app.UseStaticFiles();

// Routing konfigürasyonu
app.UseRouting();

// Varsayılan rotayı belirle
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Uygulamayı çalıştır
app.Run();

/* 
📌 Açıklamalar:

1️⃣ **builder.Services.AddControllersWithViews();**
   - MVC özelliklerini etkinleştirir.
   - Hem Controller'ları hem de View'leri destekler.

2️⃣ **app.UseStaticFiles();**
   - wwwroot klasöründeki statik dosyaların (CSS, JS, resimler) kullanılmasını sağlar.

3️⃣ **app.UseRouting();**
   - Gelen isteklerin doğru Controller ve Action'a yönlendirilmesini sağlar.

4️⃣ **app.UseEndpoints();**
   - MVC uygulamalarında Controller ve Action'ların doğru çalışmasını sağlayan rotalama sistemidir.
   - Varsayılan olarak `{controller=Home}/{action=Index}/{id?}` kullanıyoruz.
   - Bu şu anlama gelir:  
     - Kullanıcı **localhost:5000/** adresine gittiğinde **HomeController**’ın **Index** metodunu çağır.

5️⃣ **app.Run();**
   - Uygulamayı başlatır ve HTTP isteklerini dinlemeye başlar.
*/
