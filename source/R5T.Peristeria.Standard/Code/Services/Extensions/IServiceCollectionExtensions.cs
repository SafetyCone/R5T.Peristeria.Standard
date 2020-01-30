using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Peristeria.Default;


namespace R5T.Peristeria.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddDropboxDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultDropboxDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<IDropboxDirectoryNameConvention> AddDropboxDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDropboxDirectoryNameConvention>(() => services.AddDropboxDirectoryNameConvention());
            return serviceAction;
        }
    }
}
