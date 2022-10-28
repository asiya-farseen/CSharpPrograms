using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class customer
    {
        //Member variables 
        int id;
        String name;
        String email;
        String mobile;
        String city;
        // prop tab tab , to set the properties into get and set
     
        public String country { get; set; }
        public String zipcode { get; set; }
        //Constructors in c sharp 
        public customer(int id,String name,String email,String mobile,String city)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.city = city;

        }
        public string info()
        {
            return $"ID : {id} \nNAME : {name} \nEMAIL : {email} \nMOBILE : {mobile} \nCITY : {city}";
        }

    }
}
