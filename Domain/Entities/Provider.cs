using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Provider 
    {

        public String ConfirmedPassword { get; set; }

        public DateTime DateCreated { get; set; }
        public String Email { get; set; }

        public int Id { get; set; }
        public bool IsAprroved { get; set; }
        private String password { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }
          IEnumerable<Product> Products;


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
