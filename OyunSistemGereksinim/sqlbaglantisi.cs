﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OyunSistemGereksinim
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S04O6JB\\SQLEXPRESS;Initial Catalog=OyunSistemGereksinim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}


