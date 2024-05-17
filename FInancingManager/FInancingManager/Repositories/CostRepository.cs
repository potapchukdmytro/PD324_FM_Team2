using FInancingManager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInancingManager.Repositories
{
    public class CostRepository
    {
        private readonly AppDbContext _context;

        public CostRepository(AppDbContext context)
        {
            _context = context;
        }


        public void AddCost(CostEntity cost)
        {
            _context.Costs.Add(cost);
            _context.SaveChanges();
        }

        public void DeleteCost(int costId)
        {
            var cost = _context.Costs.Find(costId);
            if (cost != null)
            {
                _context.Costs.Remove(cost);
                _context.SaveChanges();
            }
        }

        public void UpdateCost(CostEntity cost)
        {
            _context.Entry(cost).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public CostEntity GetCostById(int Id)
        {
            return _context.Costs.Find(Id);
        }

        public IEnumerable<CostEntity> GetAllCosts()
        {
            return _context.Costs.ToList();
        }
    }

}
