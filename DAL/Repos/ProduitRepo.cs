using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ProduitRepo
    {
        public int Create(Produit produit)
        {
            MyDbContext db = new MyDbContext();
            db.Produits.Add(produit);
            return db.SaveChanges();
        }
        public List<Produit> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Produits.ToList();
        }
        public Produit Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Produits.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Produits.Find(id);
            dbContext.Produits.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Produit entity)
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.Produits.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
