using App001.Logic;
using App001.Objects;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace App001.AppLogic
{
    public class INIFile
    {

        #region ADDED CODE

        //////////////////////////////////////////////////////////////
        //////////////Ini files are used to manage user data.
        //////////////Values and attributes names:
        //////////////Section: User data 
        //////////////key 1: language
        //////////////values: english , spanish
        //////////////key 2: dark mode
        //////////////values: true , false
        /////////////////////////////////////////////////////////////////

        private string section_1_name_USER_DATA = "User data",
            key_1_language = "language",
            key_1_language_value_english = "english",
            key_1_language_value_spanish = "spanish",
            key_2_dark_mode = "dark mode",
            key_2_dark_mode_value_true = "true",
            key_2_dark_mode_value_false = "false",
            key_3_selected_profile = "selected profile",
            key_3_selected_profile_default_value = "No selected profile";


        public void USER_DATA_CONTROLLER_METHOD()
        {
            bool status = DOES_INI_USER_DATA_FILE_EXISTS(Run.GET_PROGRAM_PATH() + "\\" + Memory.USER_DATA_INI_FILE_NAME);
            if (status)
            {
                CHECK_INI_FILE_INTEGRITY();
                LOAD_USER_DATA();
            }
            else
            {
                CREATE_INI_USER_DATA_FILE();
            }
        }

        private void CHECK_INI_FILE_INTEGRITY()
        {
            string language = LOAD_USER_DATA_LANGUAGE();
            if (language != this.key_1_language_value_english && language != this.key_1_language_value_spanish)
            {
                CREATE_INI_USER_DATA_FILE();
            }
            string DARK_MODE_ACTIVATED = Read(this.section_1_name_USER_DATA, this.key_2_dark_mode);
            if (DARK_MODE_ACTIVATED != this.key_2_dark_mode_value_false && DARK_MODE_ACTIVATED != this.key_2_dark_mode_value_true)
            {
                CREATE_INI_USER_DATA_FILE();
            }
        }

        public bool DOES_INI_USER_DATA_FILE_EXISTS(string ini_file_path)
        {
            return File.Exists(ini_file_path);
        }

        public void CREATE_INI_USER_DATA_FILE()
        {
            Write(this.section_1_name_USER_DATA, this.key_1_language, this.key_1_language_value_english);
            Write(this.section_1_name_USER_DATA, this.key_2_dark_mode, this.key_2_dark_mode_value_false);
            Write(this.section_1_name_USER_DATA, this.key_3_selected_profile, this.key_3_selected_profile_default_value);
        }

        private void SAVE_USER_DATA(string language, bool dark_mode_activated, Profile selected_profile)
        {
            Write(this.section_1_name_USER_DATA, this.key_1_language, language);
            if (dark_mode_activated)
            {
                Write(this.section_1_name_USER_DATA, this.key_2_dark_mode, this.key_2_dark_mode_value_true);
            }
            else
            {
                Write(this.section_1_name_USER_DATA, this.key_2_dark_mode, this.key_2_dark_mode_value_false);
            }
            if (selected_profile != null)
                Write(this.section_1_name_USER_DATA, this.key_3_selected_profile, "" + selected_profile.profile_id);
            else
                Write(this.section_1_name_USER_DATA, this.key_3_selected_profile, this.key_3_selected_profile_default_value);
        }

        public void LOAD_USER_DATA()
        {
            Memory.language = LOAD_USER_DATA_LANGUAGE();
            Memory.DARK_MODE_ACTIVATED = LOAD_USER_DATA_DARK_MODE();
            Memory.SELECTED_PROFILE = LOAD_SELECTED_PROFILE();
        }

        public Profile LOAD_SELECTED_PROFILE()
        {
            string profile_id_loaded = Read(this.section_1_name_USER_DATA, this.key_3_selected_profile);
            if (Run.IS_THERE_AT_LEAST_ONE_PROFILE_STORED_ON_MEMORY())
            {
                if (IS_SELECTED_PROFILE_ID_VALUE_INTEGRITY_OK(profile_id_loaded))
                {
                    if (profile_id_loaded != this.key_3_selected_profile_default_value)
                    {
                        int profile_id = Int32.Parse(profile_id_loaded);
                        for (int i = 0; i < Memory.PROFILE_LIST.Count; i++)
                        {
                            if (Memory.PROFILE_LIST[i].profile_id == profile_id)
                            {
                                return Memory.PROFILE_LIST[i];
                            }
                        }
                    }
                    return null;
                }
                else
                {
                    //Returns firt element inside the list.
                    return Memory.PROFILE_LIST[0];
                }
            }
            else
            {
                return null;
            }
        }

        private bool IS_SELECTED_PROFILE_ID_VALUE_INTEGRITY_OK(string profile_id_loaded)
        {
            try
            {
                int profile_id = Int32.Parse(profile_id_loaded);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                CREATE_INI_USER_DATA_FILE();
                return false;
            }

        }

        public string LOAD_USER_DATA_LANGUAGE()
        {
            return Read(this.section_1_name_USER_DATA, this.key_1_language);
        }

        public bool LOAD_USER_DATA_DARK_MODE()
        {
            string status = Read(this.section_1_name_USER_DATA, this.key_2_dark_mode);
            switch (status)
            {
                case "true":
                    return true;
                case "false":
                    return false;
                default:
                    return false;
            }
        }

        //To save data on memory and ini file.
        public void SAVE_USER_DATA_ON_MEMORY_AND_INIFILE(string language, bool dark_mode_activated, Profile selected_profile)
        {
            SAVE_USER_DATA_ON_MEMORY(language, dark_mode_activated, selected_profile);
            Memory.INI_FILE.SAVE_USER_DATA(language, dark_mode_activated, selected_profile);
        }

        //To save data on ini file.
        public void SAVE_USER_DATA_ON_INIFILE(string language, bool dark_mode_activated, Profile selected_profile)
        {
            Memory.INI_FILE.SAVE_USER_DATA(language, dark_mode_activated, selected_profile);
        }

        //To save data on program memory.
        public void SAVE_USER_DATA_ON_MEMORY(string language, bool dark_mode_activated,Profile selected_profile)
        {
            Memory.language = language;
            Memory.DARK_MODE_ACTIVATED = dark_mode_activated;
            Memory.SELECTED_PROFILE = selected_profile;
        }

        #endregion

        #region CLASS CODE

        public string FilePath { get; set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
        string key,
        string val,
        string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
        string key,
        string def,
        StringBuilder retVal,
        int size,
        string filePath);

        public INIFile(string filePath)
        {
            this.FilePath = filePath;
        }

        public INIFile()
        {
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value.ToLower(), this.FilePath);
        }

        public string Read(string section, string key)
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.FilePath);
            return SB.ToString();
        }

        #endregion

    }
}

