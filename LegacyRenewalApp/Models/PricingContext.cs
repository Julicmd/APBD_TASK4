using System.Collections.Generic;

namespace LegacyRenewalApp;

public class PricingContext
{
    
    public decimal BaseAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal SubtotalAfterDiscount { get; set; }
    public string PaymentMethod { get; set; }
    public decimal SupportFee { get; set; }
    public decimal PaymentFee { get; set; }
    public List<string> Notes { get; set; } = new();

}