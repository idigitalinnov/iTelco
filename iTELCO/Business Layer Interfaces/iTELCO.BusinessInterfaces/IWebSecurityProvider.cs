namespace iTELCO.BusinessInterfaces
{
    public interface IWebSecurityProvider
    {
        string CreateUserAndAccount(string userName, string password);
        bool Login(string userName, string password);
    }
}