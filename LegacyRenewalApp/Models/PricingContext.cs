using System.Collections.Generic;

namespace LegacyRenewalApp;

public class PricingContext
{
    public string paymentMethod { get; set; }
    public decimal supportFee { get; set; }
    public decimal paymentFee { get; set; }
    
}