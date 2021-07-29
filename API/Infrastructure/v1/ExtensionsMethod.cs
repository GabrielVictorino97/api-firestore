using Domain.Model.v1.Teste;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace API.Infrastructure.v1
{
    public static class ExtensionsMethod
    {
        public static void InjectDependency(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddMediatR(typeof(RequestTest).GetTypeInfo().Assembly);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
        }
    }
}
