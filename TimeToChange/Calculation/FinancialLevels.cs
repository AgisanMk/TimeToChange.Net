using TimeToChange.Calculation.DTOs;

namespace TimeToChange.Calculation;

public static class FinancialLevels
{
    public static FinancialLevel TooLow(decimal missingAmount) => new()
    {
        Id = 1,
        Name = "Too low - This may be the perfect time to change jobs.",
        Text = "Right now, your income isn’t quite enough to fully cover the lifestyle and goals you’re aiming for – but that doesn’t mean they’re out of reach. Every big achievement starts with a clear plan, and you’ve just taken the first step by checking where you stand. Our app shows you exactly how much more you’d need each month to bridge the gap. From side gigs to smarter saving, or even a new career move, there are plenty of ways to boost your income and start moving closer to your dreams. Keep going – your future self will thank you!",
        MissingAmount = missingAmount,
        SurplusAmount = 0
    };
    
    public static FinancialLevel Optimal(decimal surplusAmount) => new()
    {
        Id = 2,
        Name = "Optimal – A strong base, and your next step could be even bigger.",
        Text = "You’ve built a solid financial foundation – your income comfortably supports your current lifestyle. But this is also the perfect stage to aim higher. With even a small boost, like exploring side projects, seizing growth opportunities at work, or setting bold new goals, you could turn your stability into true financial freedom. Every step forward now multiplies your options for the future – and your future self will thank you for taking action today.",
        MissingAmount = 0,
        SurplusAmount = surplusAmount
    };
    
    public static FinancialLevel Excellent(decimal surplusAmount) => new()
    {
        Id = 3,
        Name = "Excellent – You’re not just stable, you’re thriving.",
        Text = "Congratulation! Your income isn’t just covering your needs – it’s giving you freedom. You’re in a position where your goals feel closer than ever, and the surplus you generate each month opens the door to even bigger dreams. Whether you choose to invest, save for the future, or simply enjoy life’s luxuries, you’re in control. This is your chance to make your money work for you and shape the lifestyle you truly want.",
        MissingAmount = 0,
        SurplusAmount = surplusAmount
    };
}