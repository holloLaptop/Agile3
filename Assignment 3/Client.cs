﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Assignment_3
{
    [Serializable()]
    public class Client: Person
    {
        public String BusinessName;
        public Client() { }
        public Client(SerializationInfo info, StreamingContext ctxt)
        {
            id = (int)info.GetValue("id", typeof(int));
            name = (String)info.GetValue("name", typeof(String));
            address = (String)info.GetValue("address", typeof(String));
            landLine = (String)info.GetValue("landline", typeof(String));
            mobile = (String)info.GetValue("mobile", typeof(String));
            email = (String)info.GetValue("email", typeof(String));
            BusinessName = (String)info.GetValue("BusinessName", typeof(String));
        }
        public new void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("id", name);
            info.AddValue("name", id);
            info.AddValue("address", address);
            info.AddValue("landline", landLine);
            info.AddValue("mobile", mobile);
            info.AddValue("email", email);
            info.AddValue("BusinessName", BusinessName);
        }
    }
}
