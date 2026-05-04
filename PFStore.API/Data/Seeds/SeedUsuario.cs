using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PFStore.API.Models;

namespace PFStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region Perfis de Usuário
        List<IdentityRole> perfis = [
            new() {
                Id = "edb86810-75d4-4ce9-9c78-70e49d747e47",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new() {
                Id = "53e9ec7d-ec52-4250-88fc-deb5f6413ba9",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            },

        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuario
        List<Usuario> usuarios = [
          new () {
              Id = "250b65b2-fe68-4ad3-9667-771b13ad5363",
              Email = "admin@PFStore.com.br",
              NormalizedEmail = "ADMIN@PFSTORE.COM.BR",
              UserName = "Admin",
              NormalizedUserName = "ADMIN",
              LockoutEnabled = true,
              EmailConfirmed = true,
              Nome = "Pedro Henrique Grigolato",
              DataNascimento = DateTime.Parse("22/01/2009"),
              Foto = "/img/usuarios/250b65b2-fe68-4ad3-9667-771b13ad5363.png"
          }  
        ];
        foreach (var usuario in usuarios)
        {
            PasswordHasher<Usuario> pass = new();
            usuario.PasswordHash = pass.HashPassword(usuario, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Usuário Perfil
        #endregion   
    }
}
