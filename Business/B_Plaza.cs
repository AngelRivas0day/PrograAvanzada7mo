using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Plaza
    {
        public static bool EsPlazaFija(string Nomina)
        {
            using var db = new CetiContext();
            TrabajadorEntity trabajador = new TrabajadorEntity();
            trabajador = db.Trabajadores.Include(t => t.Plaza).FirstOrDefault(t => t.TrabajadorNomina == Nomina);
            if (trabajador?.Plaza?.PlazaTipo == "fija") return true;
            return false;
        }
    }
}
