using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarRental.Core.DataAccess.BaseClasses.EntityFramework
{
    public static class QueryableExtension
    {
        public static IQueryable<T> MyInclude<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] include) where T: class
        {
            if (include != null)
            {
                query = include.Aggregate(query, (a, b) => a.Include(b));
            }

            return query;
        }


    }
}
