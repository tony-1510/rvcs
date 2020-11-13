using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RVCS01.Class
{
    public static class Banco
    {//atributos
        public static MySqlCommand Abrir ()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strcon = @"server=10.91.43.20;user id=root;database=myescolarapp;password=@senac";
            MySqlConnection cn = new MySqlConnection(strcon);
            cmd.Connection = cn;
            return cmd;
        }

    }
}
