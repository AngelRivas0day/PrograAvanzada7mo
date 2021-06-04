using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Permiso
    {
        public static List<PermisoEntity> PermisoLista()
        {
            using var db = new CetiContext();
            return db.Permisos
                .Include(p => p.Trabajador)
                .Include(p => p.JefeInmediatio)
                .ToList();
        }

        public static PermisoEntity PermisoPorId(int Id)
        {
            using var db = new CetiContext();
            return db.Permisos.ToList().LastOrDefault(p => p.PermisoId == Id);
        }
        public static void CrearPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Add(oPermiso);
            db.SaveChanges();
        }
        public static void ActualizarPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Update(oPermiso);
            db.SaveChanges();
        }
        public static void BorrarPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Remove(oPermiso);
            db.SaveChanges();
        }
    }
}
