using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Person {     
        public int id;
        public String name;
        private String address;
        //phone numbers
        private String landLine;
        private String mobile;
        //Email
        private String email;

        public string LandLine { get => LandLine; }
        public string Mobile { get => mobile; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

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
