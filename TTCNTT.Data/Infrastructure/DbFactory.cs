namespace TTCNTT.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TTCNTTDbContext dbContext;

        public TTCNTTDbContext Init()
        {
            return dbContext ?? (dbContext = new TTCNTTDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}