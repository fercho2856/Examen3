using Examen_3.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Examen_3.Pages.Usuarios;

partial class Usuarios
{
   [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    private IEnumerable<Usuario> usuariosLista { get; set; }

    //protected override async Task OnInitialize
    //{
       // usuariosLista = await _usuarioServicio.GetLista();
    //}
}
