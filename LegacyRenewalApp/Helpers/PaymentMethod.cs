using LegacyRenewalApp.Interfaces;

namespace LegacyRenewalApp;

public class PaymentMethod:IPaymenTFeeCalc
{

    public void PayMethod(PricingContext data, DiscountContext dctx)
    {
        decimal subtotalAfterDiscount = dctx.BaseAmount - dctx.DiscountAmount;
        if (subtotalAfterDiscount < 300m)
        {
            subtotalAfterDiscount = 300m;
            dctx.Notes+="minimum discounted subtotal applied; ";
        }
        
        if (data.paymentMethod == "CARD")
        {
            data.paymentFee = (subtotalAfterDiscount + data.supportFee) * 0.02m;
            dctx.Notes+="card payment fee; ";
        }
        else if (normalizedPaymentMethod == "BANK_TRANSFER")
        {
            paymentFee = (subtotalAfterDiscount + supportFee) * 0.01m;
            notes += "bank transfer fee; ";
        }
        else if (normalizedPaymentMethod == "PAYPAL")
        {
            paymentFee = (subtotalAfterDiscount + supportFee) * 0.035m;
            notes += "paypal fee; ";
        }
        else if (normalizedPaymentMethod == "INVOICE")
        {
            paymentFee = 0m;
            notes += "invoice payment; ";
        }
        else
        {
            throw new ArgumentException("Unsupported payment method");
        }
    }
}