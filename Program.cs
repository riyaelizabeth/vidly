var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();
//app.MapControllerRoute(
//    "MoviesByReleaseDate",
//    "Movies/Released/{year}/{month}",
//    new {controller="Movies",action="ByReleaseDate"},
//    new {year=@"2015|2016",month=@"\d{2}"});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults:new {controller = "Movies", action="Random" });

app.Run();

