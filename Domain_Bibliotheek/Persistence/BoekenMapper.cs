using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using Domain_Bibliotheek.Business;

namespace Domain_Bibliotheek.Persistence
{
    internal class BoekenMapper
    {
        string _connectionstring;

        //globaal declareren van variabelen
        string _mysql;
        MySqlConnection _conn;
        MySqlCommand _cmd;
        MySqlDataReader _dr;

        public List<Boeken> Overzicht_Boeken()
        {
            //instantie van de list
            List<Boeken> _boekenlijst = new List<Boeken>();

            //doorlopen van de nodige klassen
            MySqlConnection con = new MySqlConnection(_connectionstring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("GetBoeken", con);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rd = cmd.ExecuteReader();

            //hier check ik als er wel data in de list zit
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    //instantie van de klasse Boeken
                    Boeken boek = new Boeken(rd.GetString("ISBNNummer"), rd.GetString("Titel"), rd.GetInt32("Blz"),rd.GetInt32("Graad"),rd.GetString("GenreNaam"));
                    _boekenlijst.Add(boek);
                }
                rd.Close();
                con.Close();
            }
            return _boekenlijst;
        }
        public void AddBoek(Boeken _b)
        {
            //nieuwe connectie met DB met opgegeven connections tring
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            //insert into, met gebruik van parameters voor 'values'
            MySqlCommand _cmd = new MySqlCommand("AddBoek", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van beide parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("ISBNnummer", _b.ISBN));
            _cmd.Parameters.Add(new MySqlParameter("titel", _b.Titel));
            _cmd.Parameters.Add(new MySqlParameter("graad", _b.Graad));
            _cmd.Parameters.Add(new MySqlParameter("blz", _b.Blz));
            _cmd.Parameters.Add(new MySqlParameter("genreID",_b.GenreID));

            _conn.Open(); //connectie openen
            _cmd.ExecuteNonQuery(); //toevoegen
            _conn.Close(); //connectie sluiten
        }
        public void DeleteBoek(Boeken _b)
        {
            //nieuwe connectie met DB met opgegeven connections tring
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            MySqlCommand _cmd = new MySqlCommand("RemoveBoeken", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("BoekId", _b.BoekID));

            _conn.Open(); //connectie openen
            _cmd.ExecuteNonQuery(); //toevoegen
            _conn.Close(); //connectie sluiten
        }
        public void UpdateBoek(Boeken _b)
        {
            //nieuwe connectie met DB met opgegeven connections tring
            MySqlConnection _conn = new MySqlConnection(_connectionstring);
            //nieuw MySQL-statement voor connectie 'conn' in kwestie (cf. connection string)
            //insert into, met gebruik van parameters voor 'values'
            MySqlCommand _cmd = new MySqlCommand("UpdateBoek", _conn);
            _cmd.CommandType = CommandType.StoredProcedure;
            //invullen van beide parameters voor command 'cmd'
            _cmd.Parameters.Add(new MySqlParameter("isbn", _b.OISBN));
            _cmd.Parameters.Add(new MySqlParameter("ISBNnummer", _b.ISBN));
            _cmd.Parameters.Add(new MySqlParameter("titel", _b.Titel));
            _cmd.Parameters.Add(new MySqlParameter("graad", _b.Graad));
            _cmd.Parameters.Add(new MySqlParameter("blz", _b.Blz));
            _cmd.Parameters.Add(new MySqlParameter("genreID", _b.GenreID));

            _conn.Open(); //connectie openen
            _cmd.ExecuteNonQuery(); //toevoegen
            _conn.Close(); //connectie sluiten
        }
        public BoekenMapper()
        {
            _connectionstring = "server=localhost;userid=root;database=bibliotheek;port=3306;password=1234";
        }
    }
}
