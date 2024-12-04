namespace EscapeGameService.Data
{
    public class UnitOfWork: IDisposable
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
