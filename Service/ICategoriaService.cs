public interface ICategoriaService{
     Task<IEnumerable<Categoria>> GetAll();
    Task<Categoria> GetById(int id);
    Task<Categoria> Insert(Categoria categoria);
    Task Update(int id, Categoria categoria);
    Task Delete(int id);
}