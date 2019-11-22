/*
 * Author: Erick Ruh Cardozo (W1SD00M) - <erickruhcardozo1998@gmail.com>
 * Date: Nov. 16, 2019 - 3:44 PM
 * Description: Defines the attributes of an Adress.
 */

namespace WisdomSoftware.HabittoBusinessManagement.HabittoCoreLibrary.Models
{
    public class Address
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
    }
}