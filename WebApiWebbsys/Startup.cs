using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApiWebbsys.Interface;
using WebApiWebbsys.Repository;
using WebApiWebbsys.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApiWebbsys
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
      services.AddMvc();
      services.AddCors();

      services.AddEntityFrameworkSqlServer()
              .AddDbContext<DataContext>(options =>
              {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
              });

      services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

      services.AddDbContext<DataContext>();
      services.AddScoped<IUsuarioRepository, UsuarioRepository>();

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, DataContext context)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()          
        );
      app.UseMvc();      
    }
  }
}
