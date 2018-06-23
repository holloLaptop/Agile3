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
        String PhoneToString(int phonenumber) {
            //String output = String.Format("{0:(088) 255-3820}", phonenumber);
            String output = String.Format("{0:(###) ###-####}", phonenumber);
            return output;

        }
        //converts back if needed lol
        int PhoneToInt(String phoneNumber) {
            int Output = 0;

            String temp = phoneNumber;
            Char[] characters = {' ', '(', ')', ':', '-' };
            for (int i = 0; i < characters.Length; i++) {
                temp = temp.Replace(characters[i].ToString(), "");
            }
            //replace below with conversion script
            //Output = (int) temp;

            return Output;
        }
        //Set methods for phone numbers
        public void SetLandLine(int input) {
            landLine = PhoneToString(input);
        }
        public void SetMobile(int input)
        {
            mobile = PhoneToString(input);
        }

    }
}
