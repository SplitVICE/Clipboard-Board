using System;
using System.Windows.Forms;
using App001.Logic;

namespace App001.UI
{
    public partial class MainSettings : UserControl
    {
        public MainSettings()
        {
            InitializeComponent();
        }

        public void LOAD_PAGE()
        {
            UI_LANGUAGE_CONTROL_TOGGLE();
            CHANGE_DARK_MODE_TEXT_TOGGLE();
            UI_CHANGE_DARK_LIGHT_MODE_TOGGLE();
        }

        #region LANGUAGE METHODS

        private void button_change_language_Click(object sender, EventArgs e)
        {
            //Changes language of parent window.
            Memory.main_form.UI_LANGUAGE_CONTROL_MAIN_TOGGLE();
            Run.CHANGE_LANGUAGE_TOGGLE_AND_SAVE_ON_MEMORY();
            UI_LANGUAGE_CONTROL_TOGGLE();
            Memory.INI_FILE.SAVE_USER_DATA_ON_INIFILE(Memory.language, Memory.DARK_MODE_ACTIVATED, Memory.SELECTED_PROFILE);
        }

        //Changes the user interface language
        private void UI_LANGUAGE_CONTROL_TOGGLE()
        {
            string current_language_settled_on_memory = Memory.language;
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            switch (current_language_settled_on_memory)
            {
                case "english":
                    this.label_settings_title.Text = "Settings";
                    this.button_change_language.Text = "Cambiar idioma (Español)";
                    this.button_delete_all_data.Text = "Delete all data";
                    if (IS_DARK_MODE_ACTIVATED)
                    {
                        this.button_dark_light_mode_toggle.Text = "Light Mode";
                    }
                    else
                    {
                        this.button_dark_light_mode_toggle.Text = "Dark mode";
                    }
                    break;
                case "spanish":
                    this.label_settings_title.Text = "Ajustes";
                    this.button_change_language.Text = "Change language (English)";
                    this.button_delete_all_data.Text = "Borrar todos los datos";
                    if (IS_DARK_MODE_ACTIVATED)
                    {
                        this.button_dark_light_mode_toggle.Text = "Modo claro";
                    }
                    else
                    {
                        this.button_dark_light_mode_toggle.Text = "Modo oscuro";
                    }
                    break;
            }
        }

        #endregion

        #region DARK MODE

        private void button_dark_light_mode_toggle_Click(object sender, EventArgs e)
        {
            Run.DARK_MODE_TOGGLE_AND_SAVE_ON_PROGRAM_MEMORY();
            UI_CHANGE_DARK_LIGHT_MODE_TOGGLE();
            Memory.INI_FILE.SAVE_USER_DATA_ON_INIFILE(Memory.language, Memory.DARK_MODE_ACTIVATED, Memory.SELECTED_PROFILE);
        }

        private void UI_CHANGE_DARK_LIGHT_MODE_TOGGLE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            CHANGE_BACKGROUND_COLOR_DARK_TOGGLE(IS_DARK_MODE_ACTIVATED);
            CHANGE_BUTTONS_COLOR_DARK_TOGGLE(IS_DARK_MODE_ACTIVATED);
            CHANGE_LABELS_AND_TEXT_COLOR_DARK_TOGGLE(IS_DARK_MODE_ACTIVATED);
            CHANGE_SEPARATORS_COLOR_DARK_TOGGLE(IS_DARK_MODE_ACTIVATED);
            CHANGE_DARK_MODE_TEXT_TOGGLE();
        }

        private void CHANGE_BACKGROUND_COLOR_DARK_TOGGLE(bool IS_DARK_MODE_ACTIVATED)
        {
            if (IS_DARK_MODE_ACTIVATED)
            {
                this.BackColor = Run.RETURN_BACKGROUND_COLOR_DARK();
            }
            else
            {
                this.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
            }
        }

        private void CHANGE_BUTTONS_COLOR_DARK_TOGGLE(bool IS_DARK_MODE_ACTIVATED)
        {
            if (IS_DARK_MODE_ACTIVATED)
            {
                this.button_change_language.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.button_dark_light_mode_toggle.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.button_delete_all_data.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
            }
            else
            {
                this.button_change_language.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                this.button_delete_all_data.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                this.button_dark_light_mode_toggle.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
            }
        }

        private void CHANGE_LABELS_AND_TEXT_COLOR_DARK_TOGGLE(bool IS_DARK_MODE_ACTIVATED)
        {
            if (IS_DARK_MODE_ACTIVATED)
            {
                this.button_change_language.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.button_dark_light_mode_toggle.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.button_delete_all_data.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_settings_title.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
            }
            else
            {
                this.button_change_language.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.button_dark_light_mode_toggle.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.button_delete_all_data.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_settings_title.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
            }
        }

        private void CHANGE_SEPARATORS_COLOR_DARK_TOGGLE(bool IS_DARK_MODE_ACTIVATED)
        {
            if (IS_DARK_MODE_ACTIVATED)
            {
                this.label_separator.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
            }
            else
            {
                this.label_separator.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
            }
        }

        private void CHANGE_DARK_MODE_TEXT_TOGGLE()
        {
            string CURRENT_LANGUAGE = Memory.language;
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            if (CURRENT_LANGUAGE == "english")
            {
                if (IS_DARK_MODE_ACTIVATED)
                {
                    this.button_dark_light_mode_toggle.Text = "Light mode";
                }
                else
                {
                    this.button_dark_light_mode_toggle.Text = "Dark mode";
                }
            }
            else
            {
                if (IS_DARK_MODE_ACTIVATED)
                {

                    this.button_dark_light_mode_toggle.Text = "Modo claro";
                }
                else
                {
                    this.button_dark_light_mode_toggle.Text = "Modo oscuro";
                }
            }
        }

        #endregion

        #region DELETE ALL DATA

        private void button_delete_all_data_Click(object sender, EventArgs e)
        {

        }

        //private bool ASK_USER_IF_ITS_SURE_ABOUT_DELETING_ALL_DATA()
        //{

        //}

        #endregion
    }
}
