using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StockRepo
    {
        public int Create(Stock stock)
        {
            MyDbContext db = new MyDbContext();
            db.Stocks.Add(stock);
            return db.SaveChanges();
        }
        public List<Stock> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Stocks.ToList();
        }
        public Stock Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Stocks.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Stocks.Find(id);
            dbContext.Stocks.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Stock entity)
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.Stocks.Update(entity);
            dbContext.SaveChanges();
        }
        public Stock GetStockByProduitId(int idProduit)
        {

            MyDbContext dbContext = new MyDbContext();

                return dbContext.Stocks.FirstOrDefault(stock => stock.IdProduit == idProduit);
            
        }
        public List<Stock> GetAllStocksByProduitId(int idProduit)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Stocks.Where(stock => stock.IdProduit == idProduit).ToList();
        }
    }
}
