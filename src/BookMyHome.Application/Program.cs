using BookMyHome.Infrastructure.Repository;
using BookMyHome.Infrastructure.Repository.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAccommodationRepository, AccommodationRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorOrigin", policy =>
    {
        // Replace with your Blazor app's origin (e.g. the URL where your Blazor app is running)
        policy.WithOrigins("https://localhost:8001")
              .AllowAnyHeader() // Allows headers like Content-Type  
              .AllowAnyMethod(); // Allows HTTP methods (GET, POST, etc.)  
    });
});

// Add JWT authentication
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)

//.AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = "http://localhost:7216",
//        //NB: Skal være dit port nr på din localhost webserver i asp.net – du kan finde det f.eks. ved at starte programmet og tjek browseren, så finder du din URL
//        ValidAudience = "Audience",
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("supersecretkey12345mysupersecretkeythatnobodyknows")),
//        ClockSkew = TimeSpan.Zero
//    };
//});

// Tilføjer authorization
//builder.Services.AddAuthorization(auth =>
//{
//    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
//        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
//        .RequireAuthenticatedUser().Build());
//});



builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // !!!SÆT ALTID AUTHENTICATION FØRST!!!

app.UseAuthorization(); // !EFTER!

app.MapControllers();

app.UseCors("AllowBlazorOrigin");

app.Run();
