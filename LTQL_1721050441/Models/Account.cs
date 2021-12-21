using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050441.Models
{
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Mật Khẩu không được để trống")]
        [Display(Name = "Mật Khẩu")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}