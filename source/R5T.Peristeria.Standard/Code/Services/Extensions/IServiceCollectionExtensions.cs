using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Peristeria.Default;


namespace R5T.Peristeria.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDropboxDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IDropboxDirectoryNameConvention, DropboxDirectoryNameConvention>();

            return services;
        }
    }
}
