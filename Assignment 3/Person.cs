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
    [Serializable()]
    public class Person : ISerializable
    {
        public Person() { }

        public Person(SerializationInfo info, StreamingContext ctxt)
        {
            id = (int)info.GetValue("id", typeof(int));
            name = (String)info.GetValue("name", typeof(String));
            address = (String)info.GetValue("address", typeof(String));
            landLine = (String)info.GetValue("landline", typeof(String));
            mobile = (String)info.GetValue("mobile", typeof(String));
            email = (String)info.GetValue("email", typeof(String));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("id", name);
            info.AddValue("name", id);
            info.AddValue("address",address);
            info.AddValue("landline",landLine);
            info.AddValue("mobile", mobile);
            info.AddValue("email", email);
        }

        public int id;
        public String name;
        public String address;
        //phone numbers
        public String landLine;
        public String mobile;
        //Email
        public String email;

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
