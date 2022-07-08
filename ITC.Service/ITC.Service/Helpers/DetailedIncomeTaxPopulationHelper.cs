using ITC.Models;

namespace ITC.Helpers
{
    public class DetailedIncomeTaxPopulationHelper
    {
        public static DetailedIncomeTax Populate(int income, int incomeTax)
        {
            return new DetailedIncomeTax()
            {
                GrossAnnualSalary = income,
                GrossMonthlySalary = GetAmountPerMonth(income),
                NetAnnualSalary = income - incomeTax,
                NetMontlySalary = GetAmountPerMonth(income - incomeTax),
                AnnualTaxPaid = incomeTax,
                MontlyTaxPaid = GetAmountPerMonth(incomeTax),
            };
        }

        private static decimal GetAmountPerMonth(int amount)
        {
            return GetTwoDecimalPrecision((decimal)amount / 12);
        }
        private static decimal GetTwoDecimalPrecision(decimal value)
        {
            return decimal.Round(value, 2, MidpointRounding.AwayFromZero);
        }
    }
}
