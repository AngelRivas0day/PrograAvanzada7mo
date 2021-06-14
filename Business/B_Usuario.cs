using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Business.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Usuario
    {

        public static bool UserLogin(string Nomina, string Password)
        {
            string Key = "b14ca5898a4e4133bbce2ea2315a1916";
            using var db = new CetiContext();
            TrabajadorEntity trabajador = db.Trabajadores.Include(t => t.Plaza).FirstOrDefault(t => t.TrabajadorNomina == Nomina);
            if (trabajador is null) return false;
            UsuarioEntity usuario = db.Usuarios.FirstOrDefault(u => u.TrabajadorId == trabajador.TrabajadorNomina);
            if (usuario is null) return false;
            string cPassword = Crypt.EncryptString(Key, Password);
            string uPassword = usuario.UsuarioAcceso;
            if (cPassword != uPassword) return false;
            return true;
        }
    }
}
