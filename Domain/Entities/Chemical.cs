using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public  class Chemical : Product
    {

        public String City { get; set; }

        public String LabName { get; set; }
        public String StreetAdress { get; set; }

        //public override void GetDetails()
        //{
        //    base.GetDetails();
        //    Console.WriteLine("city " + City + "LabName" + LabName+ "StreetAdress"+ StreetAdress);
        //}
        public Chemical()
        {
        }
    }
}
