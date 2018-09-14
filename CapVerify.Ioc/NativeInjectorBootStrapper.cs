using CapVerify.Data.Context;
using CapVerify.Data.Repositories;
using CapVerify.Data.UnitOfWork;
using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Interfaces.Services;
using CapVerify.Domain.Services;
using CapVerify.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CapVerify.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain - Services
            services.AddScoped<ITituloCapitalizacaoService, TituloCapitalizacaoService>();

            // ASP.NET Data
            services.AddScoped<ITituloCaptalizacaoRepository, TituloCapitalizacaoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<CapVerifyContext>();

            // ASP.NET - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
