using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase{
    private readonly ICategoriaService _categoriaService;
    public CategoriaController(ICategoriaService categoriaService){
        _categoriaService = categoriaService;
    }
}