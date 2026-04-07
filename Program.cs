var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
app.MapGet("/boltekovalihan_gmail_com", (int x, int y) => LCMclass.LCM(x, y));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class LCMclass
{
    public static String LCM(int x, int y)
    {
        if (x >= 0 && y >= 0)
        {
            int i = 1;
            while ((x * i) % y != 0)
            {
                i++;
            }
            return (x * i).ToString();
        }
        return "NaN";
    }
}
