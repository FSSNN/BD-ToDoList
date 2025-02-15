using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TarefaController : ControllerBase{
    private readonly ITarefaService _tarefaService;
    public TarefaController(ITarefaService tarefaService){
        _tarefaService = tarefaService;
    }
}