using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class MessageValidatior:AbstractValidator<Message>
    {
        public MessageValidatior()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail adresi boş bırakılamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş bırakılamaz.");
            //RuleFor(x => x.MessageContact).NotEmpty().WithMessage("Mesajı boş bırakılamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter giriniz.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En fazla 100 karakter giriniz.");
            RuleFor(x=>x.ReceiverMail).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");
        }
    }
}
