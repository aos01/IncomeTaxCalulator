using ITC.Models;

namespace ITC.Service.Interfaces
{
    public interface IDetailedIncomeTaxCalculatorService
    {
        Task<string> GetDetailedIncomeTax(int income);
    }
}
