using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductcommand(string Name,List<string> Category,string Description,string ImageFile,decimal Price):ICommand<CreateProductResult>;
    public record CreateProductResult( Guid id);
    internal class CreateProductCommandHandler : ICommnadHandler<CreateProductcommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductcommand command, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,

            };
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
