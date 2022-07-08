using ITC.Helpers;
using System.ComponentModel;

namespace ITC.Models
{
    public class DetailedIncomeTax
    {
        [DisplayName("Gross Annual Salary")]
        public decimal GrossAnnualSalary { get; set; }
        [DisplayName("Gross Monthly Salary")]
        public decimal GrossMonthlySalary { get; set; }
        [DisplayName("Net Annual Salary")]
        public decimal NetAnnualSalary { get; set; }
        [DisplayName("Net Montly Salary")]
        public decimal NetMontlySalary { get; set; }
        [DisplayName("Annual Tax Paid")]
        public decimal AnnualTaxPaid { get; set; }
        [DisplayName("Montly Tax Paid")]
        public decimal MontlyTaxPaid { get; set; }

        public override string ToString() => StringHelper.GetObjectPropertiesAndValuesAsString(this);

        public string ToJson() => Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }
}
