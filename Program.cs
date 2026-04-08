var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/boltekovalihan_gmail_com", (int x, int y) =>
{
    if (!int.TryParse(x, out int a) || !int.TryParse(y, out int b))
        return Results.Text("NaN");

    if (a < 0 || b < 0)
        return Results.Text("NaN");
    if (a == 0 && b == 0)
        return Results.Text("0");
    
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

app.Run();
