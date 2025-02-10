using System;
using System.Collections.Generic;
using Task4.Models;

namespace Task4.Serivices
{
    /// <summary>
    /// Реалізація інтерфейсу IInventoryService для обробки товарів на складі.
    /// </summary>
    public class InventoryService : IInventoryService
    {
        /// <summary>
        /// Список товарів на складі.
        /// </summary>
        private List<Product> _products = new List<Product>();

        /// <summary>
        /// Додає новий товар на склад.
        /// </summary>
        /// <param name="product">Товар для додавання.</param>
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Оновлює інформацію про товар.
        /// </summary>
        /// <param name="product">Оновлений товар.</param>
        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Category = product.Category;
                existingProduct.Quantity = product.Quantity;
            }
            else
            {
                throw new NotImplementedException("Товар не знайдений для оновлення.");
            }
        }

        /// <summary>
        /// Видаляє товар зі складу.
        /// </summary>
        /// <param name="id">Ідентифікатор товару для видалення.</param>
        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            else
            {
                throw new NotImplementedException("Товар не знайдений для видалення.");
            }
        }
    }
}