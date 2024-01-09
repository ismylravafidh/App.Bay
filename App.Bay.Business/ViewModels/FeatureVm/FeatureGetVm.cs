using App.Bay.Business.ViewModels.BaseVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.Business.ViewModels.FeatureVm
{
    public class FeatureGetVm : BaseEntityVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
