using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı boş bırakılamaz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı boş bırakılamaz.");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lüften en az 2 karakter giriniz.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçmeyiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçmeyiniz");
        }
    }
}
