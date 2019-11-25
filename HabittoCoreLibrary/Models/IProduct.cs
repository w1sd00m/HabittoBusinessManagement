/*
 * Author: Erick Ruh Cardozo (W1SD00M) - <erickruhcardozo1998@gmail.com>
 * Date: Nov. 16, 2019 - 11:10 AM
 * Description: Defines the attributes that all kinds of products will have.
 */

namespace WisdomSoftware.HabittoBusinessManagement.HabittoCoreLibrary.Models
{
    public interface IProduct
    {
        int ID { get; }
        string Barcode { get; }
        string Name { get; }
        ProductType ProductType { get; }
        decimal Price { get; }
    }
}
