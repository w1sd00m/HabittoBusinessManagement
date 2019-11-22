/*
 * Author: Erick Ruh Cardozo (W1SD00M) - <erickruhcardozo1998@gmail.com>
 * Date: Nov. 16, 2019 - 11:25 AM
 * Description: Defines a Cloth Product.
 */

namespace WisdomSoftware.HabittoBusinessManagement.HabittoCoreLibrary.Models
{
    public class ClothProduct : IProduct
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public ProductType ProductType => ProductType.Cloth;
        public ClothType ClothType { get; set; }
        public ClothSize Size { get; set; }
        public decimal Price { get; set; }
    }
}
