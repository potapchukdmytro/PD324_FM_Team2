using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FInancingManager.Models;

namespace FInancingManager.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Пошта не може бути порожньою").EmailAddress().WithName(x => x.Email);
            RuleFor(x => x.Username).MinimumLength(4).WithName("Логін").WithMessage("Мінімальна довжина логіну 4 символи");
            RuleFor(x => x.Password).MinimumLength(6).WithName("Пароль").WithMessage("Мінімальна довжина паролю 6 символів");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Паролі повинні збігатися");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ім'я не може бути порожнім");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Прізвище не може бути порожнім");
        }
    }
}
