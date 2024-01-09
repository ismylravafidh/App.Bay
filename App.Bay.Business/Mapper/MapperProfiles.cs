using App.Bay.Business.ViewModels.FeatureVm;
using App.Bay.Core.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.Business.Mapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Feature,FeatureCreateVm>();
            CreateMap<Feature,FeatureCreateVm>().ReverseMap();
            CreateMap<Feature,FeatureGetVm>();
            CreateMap<Feature,FeatureGetVm>().ReverseMap();
        }
    }
}
