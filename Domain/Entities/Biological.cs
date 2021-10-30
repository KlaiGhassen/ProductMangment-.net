using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entities
{
   public class Biological : Product
    {
        public String Herbs { get; set; }


        //public override void GetDetails()
        //{
        //    base.GetDetails();
        //    Console.WriteLine("herbs"+ Herbs);
        //}
        public Biological()
        {
        }
    }
}
