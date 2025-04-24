namespace LoanRules

type Customer = {
    Age: int
    Income: float
    CreditScore: int
}

type Loan = {
    Amount: float
    InterestRate: float
    TermMonths: int
}

type LoanRequest = {
    Customer: Customer
    Loan: Loan
}

module Eligibility =
    let isEligible (customer: Customer) (loan: Loan) = 
        customer.Age >= 18 &&
        customer.Income >= 2.0 * loan.Amount &&
        customer.CreditScore >= 650
