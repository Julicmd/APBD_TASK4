using System;
using LegacyRenewalApp.Interfaces;

namespace LegacyRenewalApp;

public class PaymentFeeCalculation:IPaymenTFeeCalc
{
    
    public decimal PayFeeCalc(PricingContext data)
    {
        decimal paymentFee;
        
        if (data.PaymentMethod == "CARD")
        {
            paymentFee = (data.SubtotalAfterDiscount + data.SupportFee) * 0.02m;
            data.Notes.Add("card payment fee; ");
        }
        else if (data.PaymentMethod == "BANK_TRANSFER")
        {
            paymentFee = (data.SubtotalAfterDiscount + data.SupportFee) * 0.01m;
            data.Notes.Add("bank transfer fee; ");
        }
        else if (data.PaymentMethod == "PAYPAL")
        {
            paymentFee = (data.SubtotalAfterDiscount + data.SupportFee) * 0.035m;
            data.Notes.Add("paypal fee; ");
        }
        else if (data.PaymentMethod == "INVOICE")
        {
            paymentFee = 0m;
            data.Notes.Add("invoice payment; ");
        }
        else
        {
            throw new ArgumentException("Unsupported payment method");
        }
        
        data.PaymentFee = paymentFee;
        return paymentFee;
    }
}