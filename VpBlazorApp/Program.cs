using DataAccess.Services;
using MudBlazor;
using MudBlazor.Services;
using VpBlazorApp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<ISqlAccess, SqlAccess>();
builder.Services.AddTransient<IMenuData, MenuData>();
builder.Services.AddTransient<IOrderData, OrderData>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IOrderGen, OrderGen>();
builder.Services.AddTransient<ICartItemService, CartItemService>();
builder.Services.AddSingleton<OrderState>();

builder.Services.AddMudBlazorSnackbar();
builder.Services.AddMudServices();
/*builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 5000;
    config.SnackbarConfiguration.HideTransitionDuration = 200;
    config.SnackbarConfiguration.ShowTransitionDuration = 200;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
