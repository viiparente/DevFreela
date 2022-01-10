using DevFreela.API.Filters;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Validators;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using DevFreela.Infrastructure.Persistence.Repositories;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace DevFreela.API
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
            //services.Configure<OpeningTimeOption>(Configuration.GetSection("OpeningTime"));

            // var connectionString = Configuration.GetConnectionString(Configuration.GetConnectionString("DevFreelaCs")) ;
            var connectionString = Configuration["ConnectionStrings:DevFreelaCs"];
            services.AddDbContext<DevFreelaDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddDbContext<DevFreelaDbContext>(options => options.UseInMemoryDatabase("Devfreela"));

            //services.AddSingleton<DevFreelaDbContext>();

            //services.AddScoped<IProjectService, ProjectService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ISkillService, SkillService>();


            //Uma instância por aplicação
            //services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stag"});

            //Uma instância por Requisição
            //services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stag" });

            //Uma instância por Classe
            //services.AddTransient<ExampleClass>(e => new ExampleClass { Name = "Initial Stag" });

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();


            services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)))
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserCommandValidator>());  

            services.AddMediatR(typeof(CreateProjectCommand));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DevFreela.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevFreela.API v1"));
            }

            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
