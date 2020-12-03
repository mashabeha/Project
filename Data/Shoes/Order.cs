using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
namespace Shop.Data.Shoes
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Вкажіть ім'я")]
        [StringLength(25)]
        [Required(ErrorMessage ="Довжина імені менше 5 знаків")]
        public string name { get; set; }

        [Display(Name = "Вкажіть прізвище")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина прізвища менше 3 знаків")]
        public string surname { get; set; }
      
        [Display(Name = "Вкажіть адресу")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина адреси менше 3 знаків")]
        public string adress{ get; set; }
        
        [Display(Name = "Введіть номер телефону")]
        [StringLength(9)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжина символів 9 знаків")]
        public string phone { get; set; }
        
        [Display(Name = "Вкажіть електронну адресу")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Введено менше 10 знаків")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail>orderDetails { get; set; }

    }
}
