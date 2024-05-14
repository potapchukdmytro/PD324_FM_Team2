using FInancingManager.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInancingManager.Validators
{
    internal class LoginValidator : AbstractValidator<LoginModel>
    {
        public LoginValidator() 
        { 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Пошта не може бути порожньою").EmailAddress().WithName(x => x.Email);
            RuleFor(x => x.Password).MinimumLength(6).WithName("Пароль").WithMessage("Мінімальна довжина паролю 6 символів");
        }

    }
}
