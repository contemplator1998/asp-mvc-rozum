namespace Rozum.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum City
    {
        Brest,
        Vitebsk,
        Gomel,
        Grodno,
        Minsk,
        Mogilev,
        Moskow,
        Kiev
    }

    public enum Status
    {
        NotMarried,
        Married,
        Devorsed
    }

    public enum Nationality
    {
        RB,
        RF,
        UA
    }

    public enum Disability
    {
        No,
        Group1,
        Group2,
        Group3
    }

    public enum Pensioner
    {
        Yes,
        No
    }

    public enum BoundToMilitary
    {
        Invalid,
        Valid,
        Servised
    }

    public enum ActivityType
    {
        Active,
        Passive,
        Active_Passive
    }

    public enum DepositType
    {
        Demand,
        Term
    }

    public enum MoneyType
    {
        Br,
        USD,
        EUR
    }
}
