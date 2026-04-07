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
app.MapGet("/boltekovalihan_gmail_com", (string x, string y) =>
{
    if (!int.TryParse(x, out int a) || !int.TryParse(y, out int b))
        return Results.Text("NaN");

    if (a < 0 || b < 0)
        return Results.Text("NaN");

    if (a == 0 || b == 0)
        return Results.Text("NaN");

    int gcd = GCD(a, b);
    long lcm = (long)a * b / gcd;

    return Results.Text(lcm.ToString());
});

int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class LCMclass
{
    public static string LCM(int x, int y)
{
    if (x < 0 || y < 0)
        return "NaN";

    if (x == 0 || y == 0)
        return "NaN";

    int a = x, b = y;

    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    int gcd = a;

    long lcm = (long)x * y / gcd;

    return lcm.ToString();
}
}
