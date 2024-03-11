using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UtilisateurRepo
    {
        public int Create(Utilisateur utilisateur)
        {
            MyDbContext db = new MyDbContext();
            db.Utilisateurs.Add(utilisateur);
            return db.SaveChanges();
        }
        public List<Utilisateur> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Utilisateurs.ToList();
        }
        public Utilisateur Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Utilisateurs.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Utilisateurs.Find(id);
            dbContext.Utilisateurs.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Utilisateur entity)
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.Utilisateurs.Update(entity);
            dbContext.SaveChanges();
        }
    }
}

