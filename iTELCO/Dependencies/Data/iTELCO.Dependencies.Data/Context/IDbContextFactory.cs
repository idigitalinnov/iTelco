namespace iTELCO.Data.Context
{
    public interface IDbContextFactory
    {
       iTELCODbContext Get();
    }
}