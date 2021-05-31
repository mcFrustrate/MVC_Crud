using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Crud.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Firstname"), Required, StringLength(50)]
        public string FirstName { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Firstname"), Required, StringLength(50)]
        public string LastName { get; set; }

        [RegularExpression(@"([0-9]+)", ErrorMessage = "Invalid Age, Must below 100"), Required, StringLength(2)]
        public int Age { get; set; }

        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Gender"), Required, StringLength(50)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Country")]
        public string country { get; set; }

        [Required(ErrorMessage = "Please Enter civil status")]
        public string civilStatus { get; set; }

        [Required(ErrorMessage = "Please Enter Religion")]
        public String Religion { get; set; }
    }
}
