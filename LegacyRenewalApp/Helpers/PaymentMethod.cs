using LegacyRenewalApp.Interfaces;

namespace LegacyRenewalApp;

public class PaymentMethod:IPaymentMethod
{

    public void PayMethod(PayContext data)
    {
        if (data.PaymentMethod == "CARD")
        {
            data.Amount = (subtotalAfterDiscount + supportFee) * 0.02m;
            data.Notes += "card payment fee; ";
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