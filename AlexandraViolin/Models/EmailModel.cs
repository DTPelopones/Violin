﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AlexandraViolin.Models
{
    public class EmailModel
    {
        private string feedbackMessage = "Отправлено";

        public string Subject { get; set; }

        [Required(ErrorMessage = "Необходимо ввести Имя.")]
        [Display(Name = "Имя")]
        [StringLength(50)]
        public string FromName { get; set; }

        [Required(ErrorMessage = "Необходимо ввести E-Mail."), Display(Name = "Email"), EmailAddress]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Не корректный E-Mail.")]
        public string FromEmail { get; set; }

        public string To { get; set; }

        public string FeedbackMessage { get { return feedbackMessage; } set { feedbackMessage = value; } }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Необходимо ввести Сообщение.")]
        [StringLength(250)]
        [Display(Name = "Сообщение")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}