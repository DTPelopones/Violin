using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AlexandraViolin.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Имя")]
        [StringLength(50)]
        public string FromName { get; set; }

        [Required, Display(Name = "Email"), EmailAddress]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Не корректный E-Mail.")]
        public string FromEmail { get; set; }

        public string To { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Сообщение")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}