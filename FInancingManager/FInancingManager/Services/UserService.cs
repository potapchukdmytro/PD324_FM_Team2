using AutoMapper;
using FInancingManager.Entities;
using FInancingManager.Models;
using FInancingManager.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInancingManager.Services
{
    public class UserService
    {
        private readonly AppDbContext context;
        private readonly Mapper mapper;
        public UserEntity actingUser = null;

        public UserService(AppDbContext context, Mapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public ServiceRepsonse Add(UserEntity entity)
        {
            try
            {
                if (IsExists(entity.Email) || IsExists(entity.UserName))
                {
                    return new ServiceRepsonse()
                    {
                        IsSuccess = false,
                        Message = $"Пошта або логін вже використовуються"
                    };
                }

                entity.Email = entity.Email.ToLower();
                context.Users.Add(entity);
                var res = context.SaveChanges() != 0;

                return new ServiceRepsonse
                {
                    IsSuccess = res,
                    Message = res ? $"Користувач {entity.UserName} успішно додано" : "Невідома помилка"
                };
            }
            catch (Exception ex)
            {
                return new ServiceRepsonse
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public UserEntity? GetByLogin(string login)
        {
            login = login.ToLower();
            return context.Users.FirstOrDefault(e => e.UserName.ToLower() == login || e.Email == login);
        }

        private bool IsExists(string login)
        {
            return GetByLogin(login) != null;
        }

        public ServiceRepsonse SignUp(SignUpModel model)
        {

            SignUpValidator validator = new SignUpValidator();
            var validatorRes = validator.Validate(model);

            if (!validatorRes.IsValid)
            {
                return new ServiceRepsonse
                {
                    IsSuccess = false,
                    Message = validatorRes.Errors[0].ErrorMessage
                };
            }

            actingUser = mapper.Map<UserEntity>(model);

            return Add(actingUser);
        }
    }
}
