﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Admin
    {
        private String username;
        private String password;
        public Admin(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        public  String getUserName()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }
    }
}
