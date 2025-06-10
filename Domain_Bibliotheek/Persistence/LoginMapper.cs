using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using Domain_Bibliotheek.Business;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Domain_Bibliotheek.Persistence
{
    internal class LoginMapper
    {
        string _connectionstring;

        //globaal declareren van variabelen
        string _mysql;
        MySqlConnection _conn;
        MySqlCommand _cmd;
        MySqlDataReader _dr;
        
        public int Controleer(Login _l)
        {
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            _conn.Open();
            MySqlCommand _cmd = new MySqlCommand("login", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van beide parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("mail", _l.Mail));
            _cmd.Parameters.Add(new MySqlParameter("wachtwoord", _l.Password));
            _dr = _cmd.ExecuteReader();

            _conn.Open(); //connectie openen
            if (_dr.Read())
            {
                return _dr.GetInt32(1); // Retourneer het aantal gebruikers dat overeenkomt
                _conn.Close(); //connectie sluiten
            }
            else
            {
                return -1;
            }
        }
        public int ControleerRecht(Login _l)
        {
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            MySqlCommand _cmd = new MySqlCommand("Rechten", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van beide parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("mail", _l.Mail));
            _dr = _cmd.ExecuteReader();

            _conn.Open(); //connectie openen
            if (_dr.Read())
            {
                return _dr.GetInt32(1); // Retourneer het id van de rechten
                _conn.Close(); //connectie sluiten
            }
            else
            {
                return 0;
            }
        }
        public LoginMapper()
        {
            _connectionstring = "server=localhost;userid=root;database=bibliotheek;port=3306;password=1234";
        }
    }
}
