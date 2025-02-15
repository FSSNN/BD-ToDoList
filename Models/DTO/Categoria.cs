public class Categoria
{
    public int id { get; set; }
    public string nome { get; set; }
    public ICollection<Tarefa> tarefas { get; set; }
}