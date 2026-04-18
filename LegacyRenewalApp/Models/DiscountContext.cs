using System.Collections.Generic;

namespace LegacyRenewalApp;

public class DiscountContext
{
    public Customer Customer { get; set; }
    public SubscriptionPlan Plan { get; set; }
    public decimal BaseAmount { get; set; }
    public bool UseLoyaltyPoints { get; set; }
    public int SeatCount { get; set; }
    public decimal DiscountAmount { get; set; }
    public string Notes { get; set; } 
}