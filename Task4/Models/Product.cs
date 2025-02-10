namespace Task4.Models
{
    /// <summary>
    /// Клас, що представляє товар на складі.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Унікальний ідентифікатор товару.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Назва товару.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Опис товару.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Категорія товару.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Кількість товару на складі.
        /// </summary>
        public int Quantity { get; set; }
        
        /// <summary>
        /// Конструктор класу Product.
        /// </summary>
        /// <param name="id">Ідентифікатор товару.</param>
        /// <param name="name">Назва товару.</param>
        /// <param name="description">Опис товару.</param>
        /// <param name="category">Категорія товару.</param>
        /// <param name="quantity">Кількість товару.</param>
        public Product(int id, string name, string description, Category category, int quantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Quantity = quantity;
        }
    }
}