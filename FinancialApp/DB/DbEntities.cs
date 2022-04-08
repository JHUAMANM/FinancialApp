using FinancialApp.Models;
namespace FinancialApp.DB;

public class DbEntities
{
    public static List<Cuenta> Cuentas = new();
    public static List<Transaccion> Transacciones = new();
    
    public static List<TipoCuenta> TipoCuentas = new()
    {
        new TipoCuenta {Id = 1, Nombre = "Efectivo"},
        new TipoCuenta{Id = 2, Nombre = "Cuenta de Banco"},
        new TipoCuenta{Id = 3, Nombre = "Tarjeta de Débito"},
        new TipoCuenta{Id = 4, Nombre = "Tarjeta de Crédito"},
        new TipoCuenta{Id = 5, Nombre = "Electrónico"},
        new TipoCuenta{Id = 5, Nombre = "Otros"}
    };
    
    
    public static List<Usuario> Usuarios = new()
    {
        new Usuario {Id = 1, Username = "admin", Password = "123456"},
        new Usuario {Id = 2, Username = "user1", Password = "123456"},
        new Usuario {Id = 3, Username = "user2", Password = "123456"},
        new Usuario {Id = 4, Username = "user3", Password = "123456"}
    };
}