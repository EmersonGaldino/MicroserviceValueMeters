using br.com.galdino.microservice.application.Interface;
using br.com.galdino.microservice.application.Service;
using br.com.galdino.microservice.domain.core.Interface;
using br.com.galdino.microservice.domain.core.Service;
using br.com.galdino.microservice.infra.data.Interface;
using br.com.galdino.microservice.infra.data.Repository;
using br.com.galdino.microservice.one.api.Filters.Performace;
using Microsoft.Extensions.DependencyInjection;

namespace br.com.galdino.microservice.one.api.Configurations.Injection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            #region .::AppService
            service.AddScoped<ISquareMeterValueAppService, SquareMeterValueAppService>();

            #endregion
            #region .::Service
            service.AddScoped<ISquareMeterService, SquareService>();

            #endregion
            #region .::Repository

            service.AddScoped<ISquareRepository, SquareRepository>(); 
            #endregion

            service.AddTransient<PerformaceFilters>();

            return service;
        }

    }
}
