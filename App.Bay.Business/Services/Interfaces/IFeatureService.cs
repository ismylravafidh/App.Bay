using App.Bay.Business.ViewModels.FeatureVm;
using App.Bay.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.Business.Services.Interfaces
{
    public interface IFeatureService
    {
        Task<List<FeatureGetVm>> GetAllAsync();
        Task<FeatureGetVm> GetByIdAsync(int id);
        Task Create(FeatureCreateVm entity);
        Task Update(FeatureUpdateVm entity);
        Task Delete(int id);

    }
}
