using ITC.Models;

namespace ITC.Service.Interfaces
{
    public interface IIncomeTaxCalculatorService
    {
        int GetIncomeTax(int income);
    }
}
