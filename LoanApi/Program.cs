using LoanRules; // reference F# DLL

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/loan", (LoanRequest request) =>
{

    var customer = request.Customer;
    var loan = request.Loan;

    bool eligible = Eligibility.isEligible(
        customer,
        loan
    );

    return Results.Ok(new
    {
        LoanEligibility = eligible ? "Approved" : "Denied"
    });
})
.WithName("PostLoan")
.WithOpenApi();

app.Run();