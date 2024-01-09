using App.Bay.Business.Services.Interfaces;
using App.Bay.Business.ViewModels.FeatureVm;
using App.Bay.Core.Common;
using App.Bay.DAL.Repository.Implementations;
using App.Bay.DAL.Repository.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.Business.Services.Implementations
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _repository;
        private readonly IMapper _mapper;

        public FeatureService(IFeatureRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<FeatureGetVm>> GetAllAsync()
        {
            IQueryable<Feature> features = await _repository.GetAllAsync();
            List<FeatureGetVm> result = new List<FeatureGetVm>();
            foreach (var feature in features)
            {
                FeatureGetVm vm = _mapper.Map<FeatureGetVm>(feature);
                result.Add(vm);
            }
            return result;
        }
        public async Task<FeatureGetVm> GetByIdAsync(int id)
        {
            Feature feature = await _repository.GetByIdAsync(id);
            FeatureGetVm featureVm = _mapper.Map<FeatureGetVm>(feature);
            return featureVm;
        }
        public async Task Create(FeatureCreateVm entity)
        {
            if (entity == null)
            {
                throw new Exception(message:"Feature null ola bilmez");
            }
            Feature feature = _mapper.Map<Feature>(entity);
            await _repository.Create(feature);
            await _repository.SaveChangesAsync();
        }
        public async Task Update(FeatureUpdateVm entity)
        {
            if (entity == null)
            {
                throw new Exception(message: "Feature null ola bilmez");
            }
            Feature oldFeature = await _repository.GetByIdAsync(entity.Id);
            _mapper.Map(oldFeature, entity);
            await _repository.Update(oldFeature);
            await _repository.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            Feature feature = await _repository.GetByIdAsync(id);
            feature.IsDeleted=true;
            await _repository.Delete(feature);
            await _repository.SaveChangesAsync();
        }
    }
}
