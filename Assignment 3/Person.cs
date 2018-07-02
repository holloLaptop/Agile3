using System;

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

        //Phone Number from int to string
        public static String PhoneToString(long phonenumber) {
            //String output = String.Format("{0:(088) 255-3820}", phonenumber);
            String output = String.Format("{0:(###) ###-####}", phonenumber);
            return output;

        }

        //converts back if needed
        static public long PhoneToInt(String phoneNumber) {
            long Output = 0;

            //Validation
            String temp = phoneNumber;
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
