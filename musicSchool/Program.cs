using musicSchool.API;
using musicSchool.Data;
using musicShool.Core.Repositories;
using musicShool.Core.Service;
using musicShool.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddCors(opt => opt.AddPolicy("Policy", policy =>
//{
//    policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
//}));

builder.Services.AddScoped<IMusicListService,MusicListService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IMusicListRepository, MusicListRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseCors("Policy");
app.UseAuthorization();

app.MapControllers();

app.Run();
