using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.Service;
using eCommerce.Core.ServiceContracts;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }

    }
}
