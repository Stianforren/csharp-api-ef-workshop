﻿using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public class CalculationRepository : ICalculationRepository
    {
        private DataContext _db;
        public CalculationRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<Calculation> Add(Calculation entity)
        {
            await _db.Calculations.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Calculation>> GetAll()
        {
            return await _db.Calculations.ToListAsync();
        }

    }
}
