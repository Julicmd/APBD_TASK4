namespace LegacyRenewalApp;

public class SubtotalCalculator
{

    public decimal SubTotalCalculate(DiscountContext ctx)
    {
        decimal subtotalAfterDiscount = ctx.BaseAmount - ctx.DiscountAmount;
        if (subtotalAfterDiscount < 300m)
        {
            subtotalAfterDiscount = 300m;
            ctx.Notes+="minimum discounted subtotal applied; ";
        }
        return subtotalAfterDiscount;
    }
}