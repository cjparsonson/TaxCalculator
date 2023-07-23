using TaxClassLib;

WriteLine("Please enter the total cost of your purchase: ");
string? cost = ReadLine();

Calculator calc = new Calculator("UK");
calc.TotalCost = Convert.ToDecimal(cost);

calc.CalculateTax();

WriteLine($"The tax amount is {calc.TaxAmount:C}");
WriteLine($"The cost minus tax is {calc.CostMinusTax:C}");
WriteLine($"The total cost is {calc.TotalCost:C}");





