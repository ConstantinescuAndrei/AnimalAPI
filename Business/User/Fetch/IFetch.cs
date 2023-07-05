using Domain;

namespace Business.User.Fetch;

public interface IFetch : ICommand<Guid, MUser>
{
}