using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Assignment_3
{
    public class Person 
    {
        public Person() { }
        
        public int id;
        public String name;
        public String address;
        //phone numbers
        public String landLine;
        public String mobile;
        //Email
        public String email;

        public String LandLine { get => landLine; }
        public String Mobile { get => mobile; }
        public String Name { get => name; set => name = value; }
        public String Address { get => address; set => address = value; }
        public String Email { get => email; set => email = value; }

        //Phone Number from int to string
        public static String PhoneToString(long phonenumber) {
            //String output = String.Format("{0:(088) 255-3820}", phonenumber);
            String output = String.Format("{0:(###) ###-####}", phonenumber);
            return output;

        }
        //converts back if needed lol
        static public long PhoneToInt(String phoneNumber) {
            long Output = 0;

            String temp = phoneNumber;
            //Validation
            String Numbers = "0123456789";
            //Stripping all foreign Characters
            for(int i = 0; i < temp.Length; i++)
            {
                if(!Numbers.Contains(temp.Substring(i, 1))) {
                    temp = temp.Replace(temp.Substring(i, 1), "");//replaces all occurances of the dissallowed character
                    i--;
                }
            }
            if (temp == "") temp = "0";
            else if (temp.Length > 10) temp = temp.Substring(0, 10);
            Output = long.Parse(temp);

            return Output;
        }
        //Set methods for phone numbers
        public void SetLandLine(long input) {
            landLine = PhoneToString(input);
        }
        public void SetMobile(long input)
        {
            mobile = PhoneToString(input);
        }

    }
}
