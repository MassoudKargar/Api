using Api.Domain.Models.Users;
using Api.Infrastructure.Repositories;
using Api.Infrastructure.SqlContext;
using Api.Interface;
using ErrorMessage;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Api.Services.Utiliry
{
    public static class StartupExtensions
    {
        public static IServiceCollection ServiceCollection(this IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(connectionString: Connection.Connectionlocal, b =>
                    b.MigrationsAssembly(assemblyName: "Api.Infrastructure"));
                options.EnableDetailedErrors(true);
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            //services.AddTransient<IMessageSender, MessageSender>();
            //services.AddTransient<IMimeTypeLookup, MimeTypeLookup>();
            //services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped(typeof(IIndex<>), typeof(Index<>));

            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.Strict;
            //});
            //services.AddIdentity<AppUser, IdentityRole<int>>()
            //    .AddEntityFrameworkStores<Context>()
            //    .AddDefaultTokenProviders()
            //    .AddErrorDescriber<PersianError>();


            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequireNonAlphanumeric = true;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequiredUniqueChars = 1;
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
            //    options.Lockout.MaxFailedAccessAttempts = 5;
            //    options.Lockout.AllowedForNewUsers = true;
            //    options.User.AllowedUserNameCharacters =
            //    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            //    options.User.RequireUniqueEmail = false;
            //});

            //services.AddAuthentication().AddGoogle(options =>
            //{
            //    // Provide the Google Client ID
            //    options.ClientId = Connection.ClientId;
            //    // Register with User Secrets using:
            //    // dotnet user-secrets set "Authentication:Google:ClientId" "{Client ID}"

            //    // Provide the Google Client Secret
            //    options.ClientSecret = Connection.ClientSecret;
            //    // Register with User Secrets using:
            //    // dotnet user-secrets set "Authentication:Google:ClientSecret" "{Client Secret}"

            //    options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
            //    options.ClaimActions.MapJsonKey("urn:google:locale", "locale", "string");
            //    options.SaveTokens = true;
            //    options.Scope.Add("https://www.googleapis.com/auth/user.birthday.read");
            //    options.Events.OnCreatingTicket = ctx =>
            //    {
            //        List<AuthenticationToken> tokens = ctx.Properties.GetTokens().ToList();

            //        tokens.Add(new AuthenticationToken()
            //        {
            //            Name = "TicketCreated",
            //            Value = DateTime.UtcNow.ToString()
            //        });

            //        ctx.Properties.StoreTokens(tokens);

            //        return Task.CompletedTask;
            //    };
            //});

            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromMinutes(60);
            //    options.Cookie.Name = "SessionCookie";
            //    //options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            //    options.Cookie.SameSite = SameSiteMode.Strict;
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            //services.Configure<PasswordHasherOptions>(option =>
            //{
            //    option.IterationCount = 12000;
            //});
            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

            //    options.LoginPath = "/Login";
            //    options.LogoutPath = "/LogOut";
            //    options.AccessDeniedPath = "/AccessDenied";
            //    options.SlidingExpiration = true;
            //});
            return services;
        }
    }
}
