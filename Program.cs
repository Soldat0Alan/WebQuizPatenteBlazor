using WebPatenteQuiz.Components;
using Patente;
using Bit.Butil;

//Carico i dati presi dal JSON solo all'avvio per non rallentare tutto.
var domande = GestioneJson.LeggiFileDomande();
var suggerimenti = GestioneJson.LeggiFileSuggerimenti();
var argomenti = GestioneJson.LeggiFileArgomento();


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()

    .AddInteractiveServerComponents();

builder.Services.AddSingleton(domande);
builder.Services.AddSingleton(suggerimenti);
builder.Services.AddSingleton(argomenti);

builder.Services.AddBlazorBootstrap();
builder.Services.AddBitButilServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
