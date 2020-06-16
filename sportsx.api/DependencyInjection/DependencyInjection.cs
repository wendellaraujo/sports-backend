using Microsoft.Extensions.DependencyInjection;
using sportsx.api.Services;
using sportsx.cliente.data;
using sportsx.cliente.data.Repository;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sportsx.api.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<PessoaContext>();
        }
    }
}
