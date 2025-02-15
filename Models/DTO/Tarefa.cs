public class Tarefa
{
    public int id { get; set; }
    public string titulo { get; set; }
    public string descricao { get; set; }
    public DateTime data { get; set; }
    public StatusEnum situacao { get; set; }
    public int IdCategoria { get; set; }
    public Categoria categoria { get; set; }
    public int IdUsuario { get; set; }
    public Usuario usuario { get; set; }

}