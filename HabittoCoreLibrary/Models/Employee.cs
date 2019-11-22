/*
 * Author: Erick Ruh Cardozo (W1SD00M) - <erickruhcardozo1998@gmail.com>
 * Date: Nov. 16, 2019 - 3:44 PM
 * Description: Defines the attributes of an Employee.
 */

using System;

namespace WisdomSoftware.HabittoBusinessManagement.HabittoCoreLibrary.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Address Address { get; set; }
        public string NID { get; set; } // RG
        public string SSN { get; set; } // CPF
        public DateTime AdmissionDate { get; set; }
    }
}
