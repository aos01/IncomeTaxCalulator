using ITC.Models;
using ITC.Service.Interfaces;

namespace ITC.Services
{
    public class IncomeTaxCalculatorService : IIncomeTaxCalculatorService
    {
        private int usedIncome;
        public IncomeTaxCalculatorService()
        { 
            usedIncome = 0; 
        }

        public int GetIncomeTax(int income)
        {
            usedIncome = income;
            return CalculateIncomeTax();
        }

        private int CalculateIncomeTax()
        {
            var overallIncomeTax = 0;
            foreach (TaxBand taxBandToApply in GetApplicableTaxBandsForIncome())
            {
                overallIncomeTax += GetCalculatedIncomeTaxForGivenTaxBand(taxBandToApply);
            }
            return overallIncomeTax;
        }

        private IEnumerable<TaxBand> GetApplicableTaxBandsForIncome()
        {
            return TaxBandServices.GetTaxBands().TaxBand.Where(t => t.RangeLowerLimit < usedIncome);
        }

        private int GetCalculatedIncomeTaxForGivenTaxBand(TaxBand currentTaxBand)
        {
            return GetAmountFallingInTaxBand(currentTaxBand) * currentTaxBand.TaxRate / 100;
        }

        private int GetAmountFallingInTaxBand(TaxBand currentTaxBand)
        {
            return (usedIncome > (currentTaxBand.RangeUpperLimit ?? usedIncome) ? currentTaxBand.AmountInRange??0 : usedIncome - currentTaxBand.RangeLowerLimit);
        }
    }
}
