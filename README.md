# Pratik - Asp.Net Core Empty
# ASP.NET Core MVC Empty Project

## 📌 Description
This project is a simple **ASP.NET Core Empty** setup following the **MVC (Model-View-Controller) architecture**. It includes necessary directories and configurations to structure the project properly.

## 📂 Project Structure
```
📂 Pratik_Asp_Net_Core_Empty
 ├── 📂 Controllers  ➝ Stores controller logic
 │    ├── HomeController.cs ✅
 ├── 📂 Models  ➝ Defines data models
 │    ├── HomeModel.cs ✅
 ├── 📂 Views  ➝ Stores UI templates
 │    ├── 📂 Home
 │    │    ├── Index.cshtml ✅
 ├── 📂 wwwroot  ➝ Stores static files (CSS, JS, images)
 ├── Program.cs  ➝ Configures application startup
```

---

## 🚀 Steps to Setup
### **1️⃣ Create Required Directories**
- Create `Controllers`, `Models`, `Views`, and `wwwroot` directories inside the project.
- Under `Views`, create a `Home` directory to store views related to the HomeController.

### **2️⃣ Implement the Home Controller**
📂 **Controllers/HomeController.cs**
```csharp
using Microsoft.AspNetCore.Mvc;
using Pratik_Asp_Net_Core_Empty.Models;

namespace Pratik_Asp_Net_Core_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Title = "ASP.NET Core Ödevine Hoşgeldiniz.",
                Description = "MVC ödevimi bitirmiş bulunmaktayım."
            };
            return View(model);
        }
    }
}
```

### **3️⃣ Define the Home Model**
📂 **Models/HomeModel.cs**
```csharp
namespace Pratik_Asp_Net_Core_Empty.Models
{
    public class HomeModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
```

### **4️⃣ Create the View**
📂 **Views/Home/Index.cshtml**
```html
@model Pratik_Asp_Net_Core_Empty.Models.HomeModel

<!DOCTYPE html>
<html>
<head>
    <title>@Model.Title</title>
</head>
<body>
    <h1>@Model.Title</h1>
    <p>@Model.Description</p>
</body>
</html>
```

### **5️⃣ Configure MVC in `Program.cs`**
📂 **Program.cs**
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Enable MVC Services
var app = builder.Build();
app.UseStaticFiles(); // Allow usage of static files (wwwroot)
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
```

---

## 🎯 MVC Concepts Explained
- **Controller**: Handles user requests (e.g., `HomeController.cs`).
- **Model**: Represents data (e.g., `HomeModel.cs`).
- **View**: Defines UI templates (`Index.cshtml`).
- **wwwroot**: Stores static files like CSS, JS, and images.
- **Routing**: Defines URL structure (`app.UseRouting()`).
- **Program.cs**: Configures application startup and middleware.

---

## 🏁 How to Run
1. Open the project in **Visual Studio**.
2. Run the application (`Ctrl + F5`).
3. Open a browser and go to:
   - `https://localhost:5001/Home/Index`

✅ You should see the message **"Welcome to ASP.NET Core"** displayed.

