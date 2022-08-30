using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogic
{
    public interface IRolesBLL
    {
        List<Roles> GetRoles();
        void AddRoles(Roles Model);
        void UpdateRole(Roles Model);
        void DeleteRoles(int ModelID);
        Roles GetRoleByID(int ID);
    }
    public class RolesBLL: IRolesBLL
    {
        private readonly ProjectContext db;
        public RolesBLL(ProjectContext _db)
        {
            db = _db;
        }
        public List<Roles> GetRoles()
        {
            return db.Roles.ToList();
        }
        public void AddRoles(Roles Model)
        {
            db.Roles.Add(Model);
            db.SaveChanges();
        }
        public void UpdateRole(Roles Model)
        {
            var getModel = db.Roles.Where(s => s.ID == Model.ID).FirstOrDefault();
            getModel.Name = Model.Name;
            db.Entry(getModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteRoles(int ModelID)
        {
            var getModel = db.Roles.Where(s => s.ID == ModelID).FirstOrDefault();
            db.Remove(getModel);
            db.SaveChanges();
        }
        public Roles GetRoleByID(int ID)
        { 
          return db.Roles.Where(s => s.ID == ID).FirstOrDefault() ;
        }
    }
}
