using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;

namespace EasyCashIdentityProject.BussinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x =>x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x =>x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x =>x.Username).NotEmpty().WithMessage("Kullanıcı alanı boş geçilemez");
            RuleFor(x =>x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x =>x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x =>x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x =>x.Name).MaximumLength(30).WithMessage("lütfen en fazla 30 karakter girişi yapın");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("lütfen en az 2 karakter veri  girişi yapın");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız aynı değil.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz");
        }
    }
}
