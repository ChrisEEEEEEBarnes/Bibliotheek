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

namespace Domain_Bibliotheek.Persistence
{
    internal class GebruikersMapper
    {
        string _connectionstring;

        //globaal declareren van variabelen
        string _mysql;
        MySqlConnection _conn;
        MySqlCommand _cmd;
        MySqlDataReader _dr;
        public List<Gebruiker> Overzicht_Gebruikers()
        {
            //instantie van de list
            List<Gebruiker> _gebruikerslijst = new List<Gebruiker>();

            //doorlopen van de nodige klassen
            MySqlConnection con = new MySqlConnection(_connectionstring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("GetGebruikers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rd = cmd.ExecuteReader();

            //hier check ik als er wel data in de list zit
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    //instantie van de klasse Boeken
                    Gebruiker gebruiker = new Gebruiker(rd.GetString("Naam"), rd.GetString("VNaam"), rd.GetString("Mail"), rd.GetString("Wachtwoord"));
                    _gebruikerslijst.Add(gebruiker);
                }
                rd.Close();
                con.Close();
            }
            return _gebruikerslijst;
        }
        public void AddGebruiker(Gebruiker _g)
        {
            //nieuwe connectie met DB met opgegeven connections tring
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            //insert into, met gebruik van parameters voor 'values'
            MySqlCommand _cmd = new MySqlCommand("AddGebruiker", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van beide parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("naam", _g.Naam));
            _cmd.Parameters.Add(new MySqlParameter("voornaam", _g.Voornaam));
            _cmd.Parameters.Add(new MySqlParameter("email", _g.Mail));
            _cmd.Parameters.Add(new MySqlParameter("wachtwoord", _g.Wachtwoord));

            _conn.Open(); //connectie openen
            _cmd.ExecuteNonQuery(); //toevoegen
            _conn.Close(); //connectie sluiten
        }
        public void DeleteGebruiker(Gebruiker _g)
        {
            //nieuwe connectie met DB met opgegeven connections tring
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            MySqlCommand _cmd = new MySqlCommand("RemoveGebruiker", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("id", _g.ID));

            _conn.Open(); //connectie openen
            _cmd.ExecuteNonQuery(); //toevoegen
            _conn.Close(); //connectie sluiten
        }
        public GebruikersMapper()
            {
                _connectionstring = "server=localhost;userid=root;database=bibliotheek;port=3306;password=1234";
            }
       }
    }
