namespace ITC.Models
{
    public class TaxBand
    {
        public string? Name { get; set; }
        public int TaxRate { get; set; }
        public int RangeLowerLimit { get; set; }
        public int? RangeUpperLimit { get; set; }
        public readonly int? AmountInRange;
        
        
        public TaxBand()
        {
        }
        public TaxBand(string name, int taxRate, int rangeLowerLimit, int? rangeUpperLimit)
        {
            this.Name = name;
            this.RangeLowerLimit = rangeLowerLimit;
            this.RangeUpperLimit = rangeUpperLimit;
            this.TaxRate = taxRate;
            this.AmountInRange = rangeUpperLimit != null ? rangeUpperLimit - RangeLowerLimit : null;

        }
    }
}
