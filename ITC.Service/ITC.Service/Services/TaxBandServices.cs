using ITC.Models;

namespace ITC.Services
{
    public class TaxBandServices
    {
        public static TaxBands GetTaxBands()
        {
            TaxBands taxBands = new();
            taxBands.TaxBand.Add(new TaxBand("BandA", 0, 0, 5000));
            taxBands.TaxBand.Add(new TaxBand("BandB", 20, 5000, 20000));
            taxBands.TaxBand.Add(new TaxBand("BandC", 40, 20000, null));
            return taxBands;
        }
    }
}
