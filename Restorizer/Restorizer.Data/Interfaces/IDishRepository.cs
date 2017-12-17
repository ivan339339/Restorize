﻿using Restorizer.Data.Model;
using Restorizer.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorizer.Data.Interfaces
{
    public interface IDishRepository : IRepository<Dish>
    {
        bool TryAdd(string name, object category, string price, List<object> ingredients);

        bool TryEdit(Dish dish, string name, object category, string price, List<DishHasIngredient> ingredients);

        IEnumerable<Object> GetByCategories();


        event MessageCallback MessageSent;

        IEnumerable<IGrouping<Dish, OrderHasDish>> GetGrouped();

        DishWithProperty GetMaxProfit();

        List<DishWithProperty> Get5LeastSold();
    }
}
