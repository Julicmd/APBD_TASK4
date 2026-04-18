using LegacyRenewalApp.Interfaces;

namespace LegacyRenewalApp;

public class SubtotalCalculator:ISubTotalCalculation
{

    public decimal SubCalculate(PricingContext ctx)
    {
        decimal subtotalAfterDiscount = ctx.BaseAmount - ctx.DiscountAmount;
        if (subtotalAfterDiscount < 300m)
        {
            subtotalAfterDiscount = 300m;
            ctx.Notes.Add("minimum discounted subtotal applied; ");
        }
        ctx.SubtotalAfterDiscount = subtotalAfterDiscount;
        return subtotalAfterDiscount;
    }
    
}