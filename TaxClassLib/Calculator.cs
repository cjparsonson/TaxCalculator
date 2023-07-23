namespace TaxClassLib;

public class Calculator
{
    // Fields
    protected string? locality;
    protected decimal taxRate;
    protected decimal costMinusTax;
    protected decimal taxAmount;
    protected decimal totalCost;

    // Properties
    public string? Locality
    {
        get { return locality; }
        set { locality = value; }
    }

    public decimal TaxRate
    {
        get { return taxRate; }
        set { taxRate = value; }
    }

    public decimal CostMinusTax
    {
        get { return costMinusTax; }
        set { costMinusTax = value; }
    }

    public decimal TaxAmount
    {
        get { return taxAmount; }
        set { taxAmount = value; }
    }

    public decimal TotalCost
    {
        get { return totalCost; }
        set { totalCost = value; }
    }

    // Constructors
    public Calculator(string Locality)
    {
        if (Locality.ToLower() == "uk")
        {
            locality = "UK";
            taxRate = 0.2m;
        }

    }

    // Methods
    private void calculateTax() // private method for encapsulation
    {
        taxAmount = taxRate * totalCost;
        costMinusTax = totalCost - taxAmount;
    }

    public void CalculateTax() // exposed method for use by client code
    {
        calculateTax();
    }

}