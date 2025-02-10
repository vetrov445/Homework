namespace Task4.Models
{
    /// <summary>
    /// Інтерфейс для обробки товарів на складі.
    /// </summary>
    public interface IInventoryService
    {
        /// <summary>
        /// Додає новий товар на склад.
        /// </summary>
        /// <param name="product">Товар для додавання.</param>
        void AddProduct(Product product);

        /// <summary>
        /// Оновлює інформацію про товар.
        /// </summary>
        /// <param name="product">Оновлений товар.</param>
        void UpdateProduct(Product product);

        /// <summary>
        /// Видаляє товар зі складу.
        /// </summary>
        /// <param name="id">Ідентифікатор товару для видалення.</param>
        void DeleteProduct(int id);
    }
}