namespace Api.Domain.CommandResult.Products
{
    public class UpdateProductResult
    {

        public UpdateProductResult(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
