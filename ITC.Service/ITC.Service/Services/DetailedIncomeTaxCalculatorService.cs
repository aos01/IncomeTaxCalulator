using ITC.Helpers;
using ITC.Models;
using ITC.Service.Interfaces;

namespace ITC.Services
{
    public class DetailedIncomeTaxCalculatorService : IDetailedIncomeTaxCalculatorService
    {
        private DetailedIncomeTax detailedIncomeTax;

        public async Task<string> GetDetailedIncomeTax(int income)
        {
            return await Task.Run(() => CalculateDetaieldIncomeTax(income).ToString());
        }

        private DetailedIncomeTax CalculateDetaieldIncomeTax(int income)
        {
            var incomeTaxCalculatorService = new IncomeTaxCalculatorService();
            detailedIncomeTax = DetailedIncomeTaxPopulationHelper.Populate(income, incomeTaxCalculatorService.GetIncomeTax(income));
            return detailedIncomeTax;
        }
    }
}
