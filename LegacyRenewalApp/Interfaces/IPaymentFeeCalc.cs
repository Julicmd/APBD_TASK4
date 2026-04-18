namespace LegacyRenewalApp.Interfaces;

public interface IPaymenTFeeCalc
{
    public void PayMethod(PricingContext data,DiscountContext dctx);
}