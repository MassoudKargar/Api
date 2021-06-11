namespace Api.Domain.CommandResult.Products
{
    public class DeleteProductResult
    {
        public DeleteProductResult(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
