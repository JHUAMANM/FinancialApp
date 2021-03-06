using System.ComponentModel.DataAnnotations;
namespace FinancialApp.Models;

public class Cuenta
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public int TipoCuentaId { get; set; }
    public decimal Monto { get; set; }
    public int UsuarioId { get; set; }
    public TipoCuenta? TipoCuenta { get; set; }
}