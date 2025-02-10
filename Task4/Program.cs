using System;
using Task4.Models;
using Task4.Serivices;

namespace Task4
{
    /// <summary>
    /// Головний клас програми.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу в програму.
        /// </summary>
        static void Main(string[] args)
        {
            // Приклад використання сервісів
            var inventoryService = new InventoryService();

            // Створення нового товару
            var product1 = new Product
            {
                Id = 1,
                Name = "Ноутбук",
                Description = "Мощний ноутбук для програмістів",
                Category = Category.Electronics,
                Quantity = 50
            };

            var product2 = new Product
            {
                Id = 2,
                Name = "Яблуко",
                Description = "Свіже зелене яблуко",
                Category = Category.Food,
                Quantity = 100
            };

            // Додаємо продукти до складу
            inventoryService.AddProduct(product1);
            inventoryService.AddProduct(product2);

            Console.WriteLine("Товари додано на склад.");

            // Виведемо всі товари на склад
            PrintInventory(inventoryService);

            // Оновлюємо кількість товару
            product1.Quantity = 120;
            inventoryService.UpdateProduct(product1);

            Console.WriteLine("\nТовари після оновлення кількості:");
            PrintInventory(inventoryService);

            // Видаляємо товар
            inventoryService.DeleteProduct(2);

            Console.WriteLine("\nТовари після видалення яблука:");
            PrintInventory(inventoryService);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод для виведення всіх товарів на склад.
        /// </summary>
        /// <param name="inventoryService">Сервіс для обробки товарів.</param>
        static void PrintInventory(IInventoryService inventoryService)
        {
            foreach (var product in inventoryService.GetAllProducts())
            {
                Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Опис: {product.Description}, " +
                                  $"Категорія: {product.Category}, Кількість: {product.Quantity}");
            }
        }
    }
}
