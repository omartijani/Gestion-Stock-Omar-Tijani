using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class SortieRepo
    {
        public int Create(Sortie sortie)
        {
            MyDbContext db = new MyDbContext();
            db.Sorties.Add(sortie);
            return db.SaveChanges();
        }
        public List<Sortie> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Sorties.ToList();
        }
        public Sortie Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Sorties.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Sorties.Find(id);
            dbContext.Sorties.Remove(obj);
            dbContext.SaveChanges();
        }

    }
}
