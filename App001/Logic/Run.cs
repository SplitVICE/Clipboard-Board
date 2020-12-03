using App001.AppLogic;
using App001.Objects;
using App001.UI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App001.Logic
{
    public class Run
    {
        public void INITIAL_RUN_METHOD()
        {
            RUN_PROGRAM_NORMALLY();
            //OPEN_TESTROOM();
        }

        private void RUN_PROGRAM_NORMALLY()
        {
            Memory.SQLITE.SQLITE_CONTROLLER_METHOD();
            Memory.INI_FILE.USER_DATA_CONTROLLER_METHOD();
            OPEN_MAIN_WINDOW();
        }

        private void OPEN_MAIN_WINDOW()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Memory.main_form = new Main());
        }

        private void OPEN_TESTROOM()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestRoom());
        }

        public static void COPY_TO_CLIPBOARD(string to_clipboard)
        {
            Clipboard.SetText(to_clipboard);
        }

        public static void OPEN_BROWSER_WITH_URL(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPEN BROWSER WITH URL ERROR. " + ex);
            }
        }

        public static string CREATE_ID()
        {
            Random random = new Random();
            string return_value = "";
            int random_number = random.Next(1000, 10000);
            return_value += random_number;
            string[] letters = { "A", "B", "C", "D", "E", "F" };
            int random_letter_selector = random.Next(1, 6);
            return_value += letters[random_letter_selector];
            return_value += random.Next(1000, 10000);
            Console.WriteLine("ID " + return_value + " created");
            return return_value;
        }

        //If the language is English, it will Spanish after
        //calling this method and MEversa.
        public static void CHANGE_LANGUAGE_TOGGLE_AND_SAVE_ON_MEMORY()
        {
            string current_language_settled_on_memory = Memory.language;
            if (current_language_settled_on_memory == "english")
            {
                Memory.language = "spanish";
            }
            else if (current_language_settled_on_memory == "spanish")
            {
                Memory.language = "english";
            }
        }

        //If dark mode is activated, it toggles it to deactivated and MEversa
        public static void DARK_MODE_TOGGLE_AND_SAVE_ON_PROGRAM_MEMORY()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            if (IS_DARK_MODE_ACTIVATED)
            {
                Memory.DARK_MODE_ACTIVATED = false;
            }
            else if (!IS_DARK_MODE_ACTIVATED)
            {
                Memory.DARK_MODE_ACTIVATED = true;
            }
        }

        public static string GET_PROGRAM_PATH()
        {
            return Path.GetDirectoryName(Application.ExecutablePath);
        }

        public static int GENERATE_RANDOM_NUMBER(int minimum, int maximum)
        {
            Random rnd = new Random();
            return rnd.Next(minimum, maximum);
        }

        public static void MESSAGEBOX(string message_content,
            string title,
            MessageBoxButtons mbButtons,
            MessageBoxIcon mbIcon)
        {
            MessageBox.Show(message_content, title, mbButtons, mbIcon);
        }

        public static bool IS_THE_TEXTBOX_NOT_EMPTY(
            string textBox_content,
            string custom_error_empty_text,
            string custom_error_empty_text_title,
            MessageBoxIcon custom_error_empty_text_title_icon,
            string custom_error_starts_with_space_text,
            string custom_error_starts_with_space_text_title,
            MessageBoxIcon custom_error_starts_with_space_text_icon)
        {
            if (!string.IsNullOrEmpty(textBox_content))
            {
                char first_char = textBox_content[0];
                if (first_char != ' ')
                {
                    return true;
                }
                else
                {
                    MESSAGEBOX(custom_error_starts_with_space_text,
                    custom_error_starts_with_space_text_title, MessageBoxButtons.OK,
                    custom_error_starts_with_space_text_icon);
                    return false;
                }
            }
            else
            {
                MESSAGEBOX(custom_error_empty_text,
                    custom_error_empty_text_title, MessageBoxButtons.OK,
                    custom_error_empty_text_title_icon);
                return false;
            }
        }

        public static void CONSOLE_MESSAGE(string str)
        {
            Console.WriteLine(str);
        }

        public static bool ASK_USER(string main_content, string title)
        {
            DialogResult result = MessageBox.Show(main_content
                , title
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IS_THERE_AT_LEAST_ONE_PROFILE_STORED_ON_MEMORY()
        {
            if (Memory.PROFILE_LIST.Count > 0)
                return true;
            else return false;
        }

        public static string LOAD_SELECTED_PROFILE_NAME()
        {
            if (IS_THERE_AT_LEAST_ONE_PROFILE_STORED_ON_MEMORY())
            {
                return Language_strings.selected_profile[Language_strings.indexer()] + Memory.SELECTED_PROFILE.sortened_profile_name();
            }
            else
            {
                return "No profiles/Sin perfiles.";
            }

        }

        public static bool IS_THERE_AT_LEAST_ONE_ITEM_ON_MEMORY()
        {
            return Memory.ITEM_LIST.Count > 0;
        }

        #region DARK MODE

        //Dark colors
        public static Color RETURN_BACKGROUND_COLOR_DARK()
        {
            Color color = new Color();
            color = Color.FromArgb(21, 32, 43);
            return color;
        }

        public static Color RETURN_BUTTON_COLOR_DARK()
        {
            Color color = new Color();
            color = Color.FromArgb(35, 49, 62);
            return color;
        }

        public static Color RETURN_LABEL_AND_TEXT_COLOR_DARK()
        {
            Color color = new Color();
            color = Color.FromArgb(255, 255, 255);
            return color;
        }

        public static Color RETURN_SEPARATOR_COLOR_DARK()
        {
            Color color = new Color();
            color = Color.FromArgb(37, 51, 65);
            return color;
        }

        //Light colors

        public static Color RETURN_BACKGROUND_COLOR_LIGHT()
        {
            Color color = new Color();
            color = Color.FromArgb(255, 255, 255);
            return color;
        }

        public static Color RETURN_BUTTON_COLOR_LIGHT()
        {
            Color color = new Color();
            color = Color.FromArgb(224, 224, 224);
            return color;
        }

        public static Color RETURN_LABEL_AND_TEXT_COLOR_LIGHT()
        {
            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            return color;
        }

        public static Color RETURN_SEPARATOR_COLOR_LIGHT()
        {
            Color color = new Color();
            color = Color.FromArgb(37, 51, 65);
            return color;
        }

        #endregion

    }
}
