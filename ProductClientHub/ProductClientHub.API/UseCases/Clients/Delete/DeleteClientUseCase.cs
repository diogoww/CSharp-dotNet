using ProductClientHub.API.Infrastructure;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Delete
{
    public class DeleteClientUseCase
    {
        public void Execute(Guid id)
        {
            var dbContext = new ProductClientHubDbContext();
            var entity = dbContext.Clients.FirstOrDefault(client => client.Id == id);
            if (entity == null)
            {
                throw new NotFoundException("Cliente não encontrado.");
            }

            dbContext.Clients.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}