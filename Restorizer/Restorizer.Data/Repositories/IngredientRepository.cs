﻿using Restorizer.Data.Interfaces;
using Restorizer.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorizer.Data.Repositories
{
    class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(Context context) : base(context) { }
    }
}
