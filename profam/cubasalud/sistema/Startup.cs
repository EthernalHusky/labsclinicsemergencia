using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;
using Database.Shared;
using Microsoft.EntityFrameworkCore;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Rotativa.AspNetCore;
using Database.Shared.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web;
using Wkhtmltopdf.NetCore;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace farmamest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddControllersWithViews();
            services.AddRazorPages();
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse("10.0.0.100"));
            });

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();

            // services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            // services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("farmaowl")));
            services.AddDbContext<Context>(options => options.UseNpgsql(Configuration.GetConnectionString("farmaowl")));
            services.AddScoped<Database.Shared.IRepository.IDespegablesProducto, Database.Shared.Data.CategoriaRepository>();
            services.AddScoped<Database.Shared.IRepository.IProducto, Database.Shared.Data.ProductosRepository>();
            services.AddScoped<Database.Shared.IRepository.IEmpleado, Database.Shared.Data.EmpleadoRepository>();
            services.AddScoped<Database.Shared.IRepository.ICliente, Database.Shared.Data.ClienteRepository>();
            services.AddScoped<Database.Shared.IRepository.IProveedor, Database.Shared.Data.ProveedorRepository>();
            services.AddScoped<Database.Shared.IRepository.IVenta, Database.Shared.Data.VentaRepository>();
            services.AddScoped<Database.Shared.IRepository.ICompra, Database.Shared.Data.CompraRepository>();
            services.AddScoped<Database.Shared.IRepository.IServicio, Database.Shared.Data.ServicioRepository>();
            services.AddScoped<Database.Shared.IRepository.IVentaServicio, Database.Shared.Data.VentaServicioRepository>();
            services.AddScoped<Database.Shared.IRepository.IEnvio, Database.Shared.Data.EnvioRepository>();
            services.AddScoped<Database.Shared.IRepository.IRuta, Database.Shared.Data.RutaRepository>();
            services.AddScoped<Database.Shared.IRepository.ICaja, Database.Shared.Data.CajaRepository>();
            services.AddScoped<Database.Shared.IRepository.IGasto, Database.Shared.Data.GastoRepository>();
            services.AddScoped<Database.Shared.IRepository.ICategoriaGasto, Database.Shared.Data.CategoriaGastoRepository>();
            services.AddScoped<Database.Shared.IRepository.IUser, Database.Shared.Data.UserRepository>();
            services.AddScoped<Database.Shared.IRepository.ICotizacion, Database.Shared.Data.CotizacionRepository>();
            services.AddScoped<Database.Shared.IRepository.ICitas, Database.Shared.Data.CitasRepository>();
            services.AddScoped<Database.Shared.IRepository.IChart, Database.Shared.Data.ChartRepository>();
            services.AddScoped<Database.Shared.IRepository.ITraslados, Database.Shared.Data.TrasladosRepository>();
            services.AddScoped<Database.Shared.IRepository.ICajaClinica, Database.Shared.Data.CajaClinicaRepository>();
            services.AddScoped<Database.Shared.IRepository.IConsultas, Database.Shared.Data.ConsultasRepository>();
            services.AddScoped<Database.Shared.IRepository.IPacientes, Database.Shared.Data.PacientesRepository>();
            services.AddScoped<Database.Shared.IRepository.ILaboratorioClinico, Database.Shared.Data.LaboratorioClinico>();



            services.Configure<IdentityOptions>(options =>
              {
                  // Password settings.
                  options.Password.RequireDigit = false;
                  options.Password.RequireLowercase = false;
                  options.Password.RequireNonAlphanumeric = false;
                  options.Password.RequireUppercase = false;
                  options.Password.RequiredLength = 6;
                  options.Password.RequiredUniqueChars = 1;

                  // Lockout settings.
                  options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
                  //options.Lockout.MaxFailedAccessAttempts = 5;
                  options.Lockout.AllowedForNewUsers = true;

                  // Default SignIn settings.
                  options.SignIn.RequireConfirmedEmail = false;
                  options.SignIn.RequireConfirmedPhoneNumber = false;

                  // User settings.
                  options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                  options.User.RequireUniqueEmail = true;

              });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
               // options.Cookie.Name = Configuration["CookieName"];
               options.Cookie.Name = "YourAppCookieName";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

            

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
            // options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // services.AddMvc(config =>
            // {
            //     var policy = new AuthorizationPolicyBuilder()
            //                     .RequireAuthenticatedUser()
            //                     .Build();
            //     config.Filters.Add(new AuthorizeFilter(policy));
            // });

            services.Configure<PasswordHasherOptions>(option =>
            {
                option.IterationCount = 12000;
            });

            services.AddWkhtmltopdf();
            // services.AddMvc().SetC services.AddWkhtmltopdf();ompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            //services.AddWkhtmltopdf("Rotativa");
            services.AddControllersWithViews().AddRazorRuntimeCompilation();


            services.AddControllersWithViews()
            .AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //cookie policy
             //app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

           app.UseDefaultFiles();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });


            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "Rotativa/Linux");
            //RotativaConfiguration.Setup(env.WebRootPath);

        }
    }
}
