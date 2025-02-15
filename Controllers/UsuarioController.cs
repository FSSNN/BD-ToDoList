using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase{
    private readonly IUsuarioService _usuarioService;
    public UsuarioController(IUsuarioService usuarioService){
        _usuarioService = usuarioService;
    }
}