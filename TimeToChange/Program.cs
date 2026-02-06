using TimeToChange.Calculation;
using TimeToChange.Calculation.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
        policy  =>
        {
            policy.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
                //.WithOrigins("https://timetochange.work");
        });
});

builder.Services.AddScoped<ICalculationService, CalculationService>();
builder.Services.AddScoped<IExpensesService, ExpensesService>();
builder.Services.AddScoped<IFinancialLevelService, FinancialLevelService>();
builder.Services.AddScoped<IGoalsService, GoalsService>();
builder.Services.AddScoped<IIncomesService, IncomesService>();



var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("CORS");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();