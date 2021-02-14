using Api.Basica.Infra.Persistence;

namespace Api.Basica.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BNCContext _context;

        public UnitOfWork(BNCContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
