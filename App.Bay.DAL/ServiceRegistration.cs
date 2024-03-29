﻿using App.Bay.DAL.Repository.Implementations;
using App.Bay.DAL.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.DAL
{
    public static class ServiceRegistration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFeatureRepository, FeatureRepository>();
        }
    }
}
