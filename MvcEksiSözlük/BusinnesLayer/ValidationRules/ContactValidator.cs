using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("E-Mail boş olamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş olamaz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş olamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu en az 3 karakterden oluşmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu en fazla 50 karakterden oluşmalıdır.");
        }
    }
}
