using MediatR;

namespace BuildingBlocks.CQRS
{

    public interface Icommand:ICommand<Unit>
    {

    }
    public interface ICommand<out Tresponse>:IRequest<Tresponse>
    {

    }
}
