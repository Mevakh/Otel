using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Descraption).NotEmpty().WithMessage("Açıklama kısmını boş geçemessiniz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Descraption).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz");
            RuleFor(x => x.Descraption).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakter kullanınız");
        }
    }
}
