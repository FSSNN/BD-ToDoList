public interface IUsuarioRepository {

    Task<IEnumerable<Usuario>> GetAll();
    Task<Usuario> GetById(int id);
    Task<Usuario> Insert(Usuario usuario);
    Task Update(int id, Usuario usuario);
    Task Delete(int id);
    
}