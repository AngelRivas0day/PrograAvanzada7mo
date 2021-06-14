using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Trabajador
    {
        public static TrabajadorEntity TrabajadorPorNomina(string Nomina)
        {
            using var db = new CetiContext();
            return db.Trabajadores
                .Include(t => t.Plaza)
                .ToList()
                .LastOrDefault(t => t.TrabajadorNomina == Nomina);
        }
        public static DateTime TrabajadorFechaDeContratacion(string Nomina)
        {
            using var db = new CetiContext();
            PuestoEntity puesto = new PuestoEntity();
            puesto = db.Puestos.FirstOrDefault(p => p.TrabajadorId == Nomina);
            return Convert.ToDateTime(puesto.PlazaFechaInicio);
        }
        public static int AcademiaDeTrabajador(string Nomina)
        {
            using var db = new CetiContext();
            return db.Puestos.FirstOrDefault(p => p.TrabajadorId == Nomina).AcademiaId;
        }
    }
}
