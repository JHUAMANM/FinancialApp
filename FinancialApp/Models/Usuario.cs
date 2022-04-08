namespace FinancialApp.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }//-> Se debe guardar como dato hash
    
}