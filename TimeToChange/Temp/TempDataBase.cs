using TimeToChange.Data;

namespace TimeToChange.Temp;

public static class TempDataBase
{
    public static List<User> Users =>
    [
        new (){ Id = 1, Name = "John", Country = Countries.First(x => x.Code == "Pl")  }
    ];
    
    private static List<Country> Countries =>
    [
        new (){ Code = "Pl", Name = "Poland", Currency = Currencies.First(x => x.Code == "PLN") }
    ];
    
    public static List<Currency> Currencies =>
    [
        new (){ Code  = "PLN", Symbol = "zł", Name = "Polish Zloty" }
    ];
}