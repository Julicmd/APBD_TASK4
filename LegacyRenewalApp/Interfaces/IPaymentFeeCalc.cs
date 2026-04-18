namespace LegacyRenewalApp.Interfaces;

public interface IPaymenTFeeCalc
{
    public decimal PayFeeCalc(PricingContext data);
}