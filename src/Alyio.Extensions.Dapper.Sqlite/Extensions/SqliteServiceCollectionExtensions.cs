﻿using Alyio.Extensions.Dapper;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up Sqlite generic repository services in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class SqliteServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Sqlite generic repository services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
        /// <param name="configurationPath">The path of dapper configuration. Default is `dapper.xml`.</param>
        /// <returns> A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddSqliteDataAccess(this IServiceCollection services, string configurationPath = "dapper.xml")
        {
            services.AddRepository(configurationPath)
                .AddSingleton<IConnectionFactory, SqliteConnectionFactory>();

            return services;
        }

        /// <summary>
        /// Adds Sqlite generic repository services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the service to.</param>
        /// <param name="setupAction">The <see cref="SqliteConnectionOptions"/> configuration delegate.</param>
        /// <param name="configurationPath">The path of dapper configuration. Default is `dapper.xml`.</param>
        /// <returns> A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddSqliteDataAccess(this IServiceCollection services, Action<SqliteConnectionOptions> setupAction, string configurationPath = "dapper.xml")
        {
            services.AddSqliteDataAccess(configurationPath).Configure(setupAction);

            return services;
        }
    }
}