using ApiAuth;
using ApiAuth.Models;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var key = Encoding.ASCII.GetBytes(Settings.Secret);

// Configurou a autenticação na aplicação
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
    x.Events = new JwtBearerEvents
    {
        OnTokenValidated = context =>
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, "colaborador")
            };
            var appIdentity = new ClaimsIdentity(claims);
            context.Principal.AddIdentity(appIdentity);
            return Task.CompletedTask;
        }
    };
});


//Configurou a autorização
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("Admin", policy => policy.RequireRole("gerente"));
    x.AddPolicy("Estagiario", policy => policy.RequireRole("estagiario"));
    x.AddPolicy("Colaborador", policy => policy.RequireRole("colaborador"));
    x.AddPolicy("CadastrarColaborador", policy => policy.RequireRole("admin"));
});

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

// Métodos
app.MapPost("/login", (User model) => { 
    
    var user = UserReposity.Get(model.UserName, model.Password);

    if (user == null)
        return Results.NotFound(new { message = "Usuário ou senha inválidos" });

    var token = TokenService.GenerateToken(user);

    return Results.Ok(new
    {
        user = user,
        token = token
    });
});


app.MapGet("/autenticado", (ClaimsPrincipal user) =>
{
    var mensagem = "Autenticado como " + user.Identity.Name;

    return Results.Ok(mensagem);
}).RequireAuthorization();


app.MapGet("/saldo", (ClaimsPrincipal user) =>
{
    var mensagem = "Seu saldo é R$ 1.000.000.000,00";

    return Results.Ok(mensagem);
}).RequireAuthorization("Admin");


app.MapPost("/cadastrarCliente", (Client model) => {
    var user = UserReposity.Get(model.UserName, model.Password);

    if (user == null)
        return Results.NotFound(new
        {
            message = "Usuário ou senha inválidos"
        });

    var claimsIdentity = (ClaimsIdentity)user.Identity;
    var roles = claimsIdentity.FindAll(ClaimTypes.Role).Select(c => c.Value);

    if (!roles.Contains("colaborador"))
        return Results.Forbidden(new
        {
            message = "Usuário não autorizado para cadastrar clientes"
        });


    return Results.Ok(new
    {
        message = "Cliente cadastrado com sucesso"
    });
}).RequireAuthorization("Colaborador");


app.MapPost("/cadastrarColaborador", (Colaborador model) => {
    var user = UserReposity.Get(model.UserName, model.Password);

    if (user == null)
        return Results.NotFound(new
        {
            message = "Usuário ou senha inválidos"
        });

    var claimsIdentity = (ClaimsIdentity)user.Identity;
    var roles = claimsIdentity.FindAll(ClaimTypes.Role).Select(c => c.Value);

    if (!roles.Contains("admin"))
        return Results.Forbidden(new
        {
            message = "Apenas administradores podem cadastrar colaboradores"
        });


    return Results.Ok(new
    {
        message = "Colaborador cadastrado com sucesso"
    });
}).RequireAuthorization("CadastrarColaborador");


app.MapPost("/cadastrarCliente", (Client model, ClaimsPrincipal user) => {
    var loggedInUserId = user.FindFirstValue(ClaimTypes.NameIdentifier); 
    model.ColaboradorId = loggedInUserId; 

    

    return Results.Ok(new
    {
        message = "Cliente cadastrado com sucesso"
    });
}).RequireAuthorization("Colaborador");


app.MapGet("/meusClientes", (ClaimsPrincipal user) => {
    var loggedInUserId = user.FindFirstValue(ClaimTypes.NameIdentifier);

    return Results.Ok(new
    {
        message = "Lista de clientes do colaborador",
        clients = clients
    });
}).RequireAuthorization("Colaborador");

app.Run();
