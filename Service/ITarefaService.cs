public interface ITarefaService{
     Task<IEnumerable<Tarefa>> GetAll();
    Task<Tarefa> GetById(int id);
    Task<Tarefa> Insert(Tarefa tarefa);
    Task Update(int id, Tarefa tarefa);
    Task Delete(int id);
}