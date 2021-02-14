namespace Api.Basica.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
