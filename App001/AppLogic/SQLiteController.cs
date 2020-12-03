using App001.Logic;
using App001.Objects;
using System;
using System.Data;
using System.IO;
using App001.AppLogic;

namespace App001.AppLogic
{
    public class SQLiteController : SQLite
    {
        public SQLiteController() : base(Memory.SQLITE_DATABASE_PATH)
        {
        }

        public void SQLITE_CONTROLLER_METHOD() 
        {
            if (DATABASE_EXISTS())
            {
                LOAD_DATA();
            }
            else
            {
                CREATE_DATA_BASE();
            }
        }

        private bool DATABASE_EXISTS()
        {
            return File.Exists(Memory.SQLITE_DATABASE_PATH);
        }

        public void LOAD_DATA()
        {
            LOAD_DATA_PROFILES();
            LOAD_DATA_ITEMS();
        }

        private void LOAD_DATA_PROFILES()
        {
            DataSet profiles = Fetch("SELECT * FROM PROFILE", "Items from PROFILE table readed.");
            for (int i = 0; i < profiles.Tables[0].Rows.Count; i++)
            {
                Profile temp_profile = new Profile();
                temp_profile.profile_name = profiles.Tables[0].Rows[i]["profile_name"].ToString();
                temp_profile.profile_id = Int32.Parse(profiles.Tables[0].Rows[i]["program_id"].ToString());
                Memory.PROFILE_LIST.Add(temp_profile);
            }
        }

        private void LOAD_DATA_ITEMS()
        {
            DataSet items = Fetch("SELECT * FROM ITEM", "Items from ITEM table readed.");
            for (int i = 0; i < items.Tables[0].Rows.Count; i++)
            {
                Item temp_item = new Item();
                temp_item.item_name = items.Tables[0].Rows[i]["item_name"].ToString();
                temp_item.item_id = Int32.Parse(items.Tables[0].Rows[i]["program_id"].ToString());
                temp_item.item_content = items.Tables[0].Rows[i]["item_content"].ToString();
                temp_item.profile_id = Int32.Parse(items.Tables[0].Rows[i]["parent_profile_id"].ToString());
                Memory.ITEM_LIST.Add(temp_item);
            }
        }

        private void CREATE_DATA_BASE()
        {
            string query_create_item = "CREATE TABLE \"ITEM\" ( \"ID\" INTEGER NOT " +
                "NULL PRIMARY KEY AUTOINCREMENT UNIQUE, \"program_id\" INTEGER, " +
                "\"item_name\" TEXT, \"item_content\" TEXT," +
                " \"parent_profile_id\" INTEGER );";
            string query_create_profile = "CREATE TABLE \"PROFILE\"( \"ID\" INTEGER NOT " +
                "NULL PRIMARY KEY " +
                "AUTOINCREMENT UNIQUE, \"program_id\" INTEGER, \"profile_name\" TEXT )";
            ////////////////////////////////////////////////////////////////////////////////
            Query(query_create_item, "Table ITEM created.");
            Query(query_create_profile, "Table PROFILE created.");
        }

        public void SAVE_NEW_PROFILE(Profile temp_profile)
        {
            string query_str = "INSERT INTO PROFILE" +
                "(program_id, profile_name)" +
                "VALUES('" + temp_profile.profile_id + "','" + temp_profile.profile_name + "')";
            Query(query_str, "Profile " + temp_profile.profile_name + " inserted in DataBase.");
        }
    }
}
