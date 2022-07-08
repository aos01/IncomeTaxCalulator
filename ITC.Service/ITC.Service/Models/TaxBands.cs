namespace ITC.Models
{
    public class TaxBands
    {
        public List<TaxBand> TaxBand { get; set; }

        public TaxBands()
        {
            TaxBand = new List<TaxBand>();
        }
    }
}
