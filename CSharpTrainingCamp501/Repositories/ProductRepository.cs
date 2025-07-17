using CSharpTrainingCamp501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingCamp501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        Task IProductRepository.CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        Task IProductRepository.DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<ResultProductDto>> IProductRepository.GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        Task IProductRepository.GetByProductIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IProductRepository.UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
