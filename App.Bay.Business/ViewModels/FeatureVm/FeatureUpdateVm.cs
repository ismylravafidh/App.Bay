using App.Bay.Business.ViewModels.BaseVm;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Bay.Business.ViewModels.FeatureVm
{
    public class FeatureUpdateVm:BaseEntityVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Icon { get; set; }
    }
    public class FeauterUpdatevmValidation : AbstractValidator<FeatureUpdateVm>
    {
        public FeauterUpdatevmValidation()
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("Bos Ola Bilmez").MaximumLength(50).WithMessage("Uzunlug max 50 ola biler");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Bos Ola Bilmez");
        }
    }
}
