using FInancingManager.Entities;
using FInancingManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInancingManager.Services
{
    public class CostService
    {
        private readonly CostRepository _costRepository;

        public CostService(CostRepository costRepository)
        {
            _costRepository = costRepository;
        }

        public ServiceRepsonse AddCost(CostEntity cost)
        {
            try
            {
                _costRepository.AddCost(cost);
                return new ServiceRepsonse
                {
                    IsSuccess = true,
                    Message = $"Витрата {cost.Name} успішно додана"
                };
            }
            catch (Exception ex)
            {
                return new ServiceRepsonse
                {
                    IsSuccess = false,
                    Message = $"Помилка під час додавання витрати: {ex.Message}"
                };

            }

        }

        public ServiceRepsonse DeleteCost(int costId)
        {
            try
            {
                _costRepository.DeleteCost(costId);
                return new ServiceRepsonse
                {
                    IsSuccess = true,
                    Message = $"Витрата з ID {costId} успішно видалена"
                };
            }
            catch (Exception ex)
            {
                return new ServiceRepsonse
                {
                    IsSuccess = false,
                    Message = $"Помилка під час видалення витрати: {ex.Message}"
                };

            }


        }

        public ServiceRepsonse UpdateCost(CostEntity cost)
        {
            try
            {
                _costRepository.UpdateCost(cost);
                return new ServiceRepsonse
                {
                    IsSuccess = true,
                    Message = $"Витрата з ID {cost.Id} успішно оновлена"
                };
            }
            catch (Exception ex)
            {
                return new ServiceRepsonse
                {
                    IsSuccess = false,
                    Message = $"Помилка під час оновлення витрати: {ex.Message}"
                };

            }
        }

        public CostEntity GetCostById(int costId)
        {
            return _costRepository.GetCostById(costId);
        }


        public IEnumerable<CostEntity> GetAllCosts()
        {
            return _costRepository.GetAllCosts();
        }




    }
}
