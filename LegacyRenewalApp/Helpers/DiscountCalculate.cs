using LegacyRenewalApp.Interfaces;

namespace LegacyRenewalApp;

public class DiscountCalculate:IDiscountCalculate
{
    
    public decimal CalculateDiscount(DiscountContext data)
    {
        
        if (data.Customer.Segment == "Silver")
            {
                data.DiscountAmount += data.BaseAmount * 0.05m;
                data.Notes.Add("silver discount;"); 
            }
            else if (data.Customer.Segment == "Gold")
            {
                data.DiscountAmount += data.BaseAmount * 0.10m;
                data.Notes.Add("gold discount;");
            }
            else if (data.Customer.Segment == "Platinum")
            {
                data.DiscountAmount += data.BaseAmount * 0.15m;
                data.Notes.Add("platinum discount; ");
            }
            else if (data.Customer.Segment == "Education" && data.Plan.IsEducationEligible)
            {
                data.DiscountAmount += data.BaseAmount * 0.20m;
                data.Notes.Add("education discount; ");
            }

            if (data.Customer.YearsWithCompany >= 5)
            {
                data.DiscountAmount += data.BaseAmount * 0.07m;
                data.Notes.Add("long-term loyalty discount; ");
            }
            else if (data.Customer.YearsWithCompany >= 2)
            {
                data.DiscountAmount += data.BaseAmount * 0.03m;
                data.Notes.Add("basic loyalty discount; ");
            }

            if (data.SeatCount >= 50)
            {
                data.DiscountAmount += data.BaseAmount * 0.12m;
                data.Notes.Add("large team discount; ");
            }
            else if (data.SeatCount >= 20)
            {
                data.DiscountAmount += data.BaseAmount * 0.08m;
                data.Notes.Add("medium team discount; ");
            }
            else if (data.SeatCount >= 10)
            {
                data.DiscountAmount += data.BaseAmount * 0.04m;
                data.Notes.Add("small team discount; ");
            }

            if (data.UseLoyaltyPoints && data.Customer.LoyaltyPoints > 0)
            {
                int pointsToUse = data.Customer.LoyaltyPoints > 200 ? 200 : data.Customer.LoyaltyPoints;
                data.DiscountAmount += pointsToUse;
                data.Notes.Add($"loyalty points used: {pointsToUse}; ");
            }
            
            return data.DiscountAmount;
    }
}