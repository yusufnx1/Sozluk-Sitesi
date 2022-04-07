using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş bırakılamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lüften en az 3 karakter giriniz.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz.");
        }
    }
}
