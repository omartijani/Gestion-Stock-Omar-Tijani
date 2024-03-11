using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EntreeRepo
    {
        public int Create(Entree entree)
        {
            MyDbContext db = new MyDbContext();
            db.Entrees.Add(entree);
            return db.SaveChanges();
        }
        public List<Entree> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Entrees.ToList();
        }
        public Entree Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Entrees.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Entrees.Find(id);
            dbContext.Entrees.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Entree entity)
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.Entrees.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
