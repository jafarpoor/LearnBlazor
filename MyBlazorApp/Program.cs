using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.ShoppingCart;
using MyBlazor.Libraries.Storage;
using MyBlazorApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IStorageService, StorageService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IShoppingCartService, ShoppingCartService>();

await builder.Build().RunAsync();
