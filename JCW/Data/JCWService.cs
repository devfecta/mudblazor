using JCW.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;

namespace JCW.Data
{
    public class JCWService
    {
        public static void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(options => { 
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }
        /*
        public static void ConfigureMySqlContext(IServiceCollection services, IConfiguration config) {
            var connectionString = config["ConnectionStrings:MySqlConnectionString"];
            services.AddDbContext<JCWContext>(options => options.UseMySql(connectionString, MySqlServerVerion.LastestSupportedServerVersion));
        }
        */
        /*
        public static void ConfigureRepositoryWrapper(IServiceCollection services) {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        */
    }
}
