using AllBizz.Business.DTOs.SliderDtos;
using AllBizz.Business.MappingProfile;
using AllBizz.Business.Service.Implementations;
using AllBizz.Business.Service.Interfaces;
using AllBizz.Core.Repository.Interfaces;
using AllBizz.Data.DAL;
using AllBizz.Data.Repository.Implementations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(opt =>
{
    opt.RegisterValidatorsFromAssembly(typeof(SliderCreateDtoValidator).Assembly);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISliderRepository,SliderRepository>();
builder.Services.AddScoped<ISliderService,SliderService>();

builder.Services.AddScoped<IServicesService, ServicesService>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<IProfessionRepository, ProfessionRepository>();
builder.Services.AddScoped<IProfessionService ,ProfessionService>();


builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IMemberService, MemberService>();

builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=MSI;Database=AllBizz;Trusted_Connection=true;");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
