﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Models.Domain
{
    public interface IFormulaRepository
    {
        IEnumerable<Formula> GetAll();
        Formula GetById(int formulaId);
        Formula GetLinkedMembers(int formulaId);
        void SaveChanges();
    }
}