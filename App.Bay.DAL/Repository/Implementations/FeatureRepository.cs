using App.Bay.Core.Common;
using App.Bay.DAL.Common;
using App.Bay.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.DAL.Repository.Implementations
{
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        public FeatureRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
