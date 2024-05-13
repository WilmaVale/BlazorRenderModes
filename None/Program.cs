using None.Components;

var builder = WebApplication.CreateBuilder(args);

// Aggiunge servizi al contenitore
// AddRazorComponents: registra i servizi richiesti per il rendering (elaborazione) lato server di Razor Components
builder.Services.AddRazorComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// MapRazorComponents:
// Mappa i componenti della pagina definiti nel TRootComponent
// specificato all'assembly specificato ed
// esegue il rendering del componente specificato da TRootComponent quando il percorso corrisponde
app.MapRazorComponents<App>();

app.Run();
