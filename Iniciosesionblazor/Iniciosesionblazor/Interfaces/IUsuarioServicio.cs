using Modelos;

namespace BlazorIniciosesion.Interfaces;

public interface IUsuarioServicio
{
    Task<Usuario> GetPorCodigo(string codigo);
}
