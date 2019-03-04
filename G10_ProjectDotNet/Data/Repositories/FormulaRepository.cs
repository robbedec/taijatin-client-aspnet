﻿using G10_ProjectDotNet.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Data.Repositories
{
    public class FormulaRepository : IFormulaRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Formula> _formulas;

        public FormulaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _formulas = dbContext.Formulas;
        }

        public IEnumerable<Formula> GetAll()
        {
            return _formulas.Include(b => b.Teacher).Include(b => b.Members).ToList();
        }

        public Formula GetById(int formulaId)
        {
            return _formulas.Where(b => b.FormulaId == formulaId).SingleOrDefault();
        }

        public Formula GetLinkedMembers(int formulaId)
        {
            var selectedFormula = _formulas.Where(x => x.FormulaId == formulaId).Single();
            _dbContext.Entry(selectedFormula).Collection(x => x.Members).Load();
            return selectedFormula;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}