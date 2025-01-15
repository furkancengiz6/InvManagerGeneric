using InvManager.Data;
using InvManager.Entities.concretes;
using InvManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvManager.Services.Concrete
{
    public class InventoryService : IInventoryService
    {

        private readonly Repository<Product> _productRepository;

        public InventoryService(Repository<Product> productRepository) 
        {
            _productRepository = productRepository; 
        
        }



        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Remove(int productId)
        {
            _productRepository.Remove(productId);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
