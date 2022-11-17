using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockhouse
{
    /// <summary>
    /// Сущность товара
    /// </summary>
    public class Tovar
    {
        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена без НДС
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Материал
        /// </summary>
        public material Material { get; set; }

        /// <summary>
        /// Размер
        /// </summary>
        public decimal Size { get; set; }
        
        /// <summary>
        /// Количество
        /// </summary>
        public decimal count { get; set; }

        /// <summary>
        /// Минимальное количество
        /// </summary>
        public decimal minCount { get; set; }
     
    }
}
