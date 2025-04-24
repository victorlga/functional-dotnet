using LoanRules;

var customer = new Customer(30, 60000, 700);
var loan = new Loan(12000, 1.05, 12);

bool isEligible = Eligibility.isEligible(
    customer,
    loan
);

Console.WriteLine($"isEligible: {isEligible}");
