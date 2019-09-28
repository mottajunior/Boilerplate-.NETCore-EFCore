using UserService.Infra.Context;
using UserService.Domain.Entities;
using UserService.Domain.IRepositories;

namespace UserService.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context) { }
    }
}
