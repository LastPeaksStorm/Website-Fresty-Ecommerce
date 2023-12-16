global using FrestyEcommerce.Shared;
global using System.Net.Http.Json;
global using FrestyEcommerce.Client.Services.ProductService;
global using FrestyEcommerce.Client.Services.CategoryService;
global using Microsoft.AspNetCore.Components.Authorization;
global using FrestyEcommerce.Client.Services.OrderService;
global using FrestyEcommerce.Client.Services.CartService;
global using FrestyEcommerce.Client.Services.AuthService;
global using FrestyEcommerce.Client.Services.AddressService;
global using FrestyEcommerce.Client.Services.ProductTypeService;
using FrestyEcommerce.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();
