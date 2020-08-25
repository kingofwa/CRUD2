using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionID { set; get; }

        [MaxLength(12)]
        [Required(ErrorMessage ="Truong nay khong duoc de trong")]
        [DisplayName("Account Controller")]
        [Column(TypeName = "varchar(12)")]
        public String AccountController { set; get; }

        [Required(ErrorMessage = "Truong nay khong duoc de trong")]
        [DisplayName("Beneficary Name")]
        [Column(TypeName = "varchar(100)")]
        public String BeneficaryName { set; get; }

        [Required(ErrorMessage = "Truong nay khong duoc de trong")]
        [DisplayName("Bank Name")]
        [Column(TypeName = "varchar(100)")]
        public String BankName { set; get; }

        [MaxLength(11)]
        [Required(ErrorMessage = "Truong nay khong duoc de trong")]
        [DisplayName("Code")]
        [Column(TypeName = "varchar(11)")]
        public String Code { set; get; }

        [Required(ErrorMessage = "Truong nay khong duoc de trong")]
        [DisplayName("Amount")]
        public String Amount { set; get; }

        [Required(ErrorMessage = "Truong nay khong duoc de trong")]
        public DateTime Date { set; get; }

    }
}
