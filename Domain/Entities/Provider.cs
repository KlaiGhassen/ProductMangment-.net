using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Provider 
    {
       [Key]
        public int Id { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="languer minimale de password doit etre au min 8 caractére")]
        [Required(ErrorMessage ="champ password obligatoire")]
        public String Password { get; set; }

        [Required(ErrorMessage = "champ ConfirmedPassword est obligatoire")]
        [NotMapped]
        [DataType(DataType.Password)]
[Compare("Password",ErrorMessage ="le confirm password ne corespont pas password")]
        public String ConfirmedPassword { get; set; }

        public DateTime DateCreated { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public String Email { get; set; }
        public bool IsAprroved { get; set; }
        private String password { get; set; }
        public String UserName { get; set; }
        virtual public ICollection<Product> Products { get; set; }


        public Provider()
        {
            Password = password;
        }

        public static void SetIsApproved(Provider p) {
            
            p.IsAprroved = false;


            if (String.Compare(p.password, p.ConfirmedPassword) == 0)
            {

                p.IsAprroved = true;

            }
            Console.WriteLine(p.IsAprroved);






        }
        public static void SetIsApproved(string password, string ConfirmedPassword, bool isApproved) {
            isApproved = false;

            if (String.Compare(password, ConfirmedPassword) == 0) {
                isApproved = true;

            }

            Console.WriteLine(isApproved);

            }

        //public override void GetDetails()
        //{
        //    Console.WriteLine("UserName" + UserName + "DateCreated" + DateCreated + "Email" + Email + "Id" + Id + "IsAprroved" + IsAprroved + "Password" + password);
        //}
    }

        

     
    
}
