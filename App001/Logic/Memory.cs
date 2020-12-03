using App001.AppLogic;
using App001.UI;
using System.Collections.Generic;
using App001.Objects;

namespace App001.Logic
{
    public class Memory
    {
        //////////////////////////////////////////////////////////////////////////////
        ///////////PROGRAM MEMORY CLASS.
        ///////////THIS CLASS CONTAINS ALL THE IMPORTANT MEMORY ATTRIBUTES.
        ///////////THEY ARE ALL STATIC TO BE ACCESSED BY THE PROGRAM AT ANY PLACE.
        ///////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        ///////STRING ATTRIBUTES.
        //////
        public static string app_name = "Clipboard Board";
        public static string version = "1.0";
        //DEFAULT VALUES: english or spanish
        public static string language = "english";
        //PANEL TO START THE PROGRAM WITH.
        public static string INITIAL_PANEL = "ItemManagement";
        //USER DATA .INI FILE NAME
        public static string USER_DATA_INI_FILE_NAME = "cbbuserdata.ini";
        public static string USER_DATA_INI_FILE_PATH = Run.GET_PROGRAM_PATH() + "\\" + USER_DATA_INI_FILE_NAME;
        //SQLITE DATABASE VALUES
        public static string SQLITE_DATABASE_NAME = "cbbdata.db";
        public static string SQLITE_DATABASE_PATH = Run.GET_PROGRAM_PATH() + "\\" + SQLITE_DATABASE_NAME;
        /////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        ///////BOOLEAN ATTRIBUTES.
        /////////
        public static bool DARK_MODE_ACTIVATED = false;
        /////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        ///////OBJECT ATTRIBUTES.
        /////////
        public static Main main_form;
        public static INIFile INI_FILE = new INIFile(USER_DATA_INI_FILE_PATH);
        public static SQLiteController SQLITE = new SQLiteController();
        public static List<Profile> PROFILE_LIST = new List<Profile>();
        public static List<Item> ITEM_LIST = new List<Item>();
        public static Profile SELECTED_PROFILE;
        public static Item SELECTED_ITEM;
        /////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        ///////Enums.
        /////////

        /////////////////////////////////////////////////////////////////////
    }
}
