using System;
using System.Drawing;
using System.Windows.Forms;
using App001.Logic;

namespace App001.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UI_SETTINGS();
            this.Text = Memory.app_name;
        }

        private void UI_SETTINGS()
        {
            UI_LANGUAGE_CONTROL_MAIN_ON_PROGRAM_LOAD();
            LOAD_USER_CONTROL_PANEL(Memory.INITIAL_PANEL);
            CENTER_WINDOW();
        }

        #region DARK MODE
        private void CENTER_WINDOW()
        {
            this.CenterToScreen();
        }
        private void LOAD_USER_CONTROL_PANEL(string option)
        {
            switch (option)
            {
                //Home
                //ProfileManagement
                //ItemManagement
                //Settings
                //About
                case "Home":
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(0, 61);
                    this.mainMain1.BringToFront();
                    this.mainMain1.LOAD_PAGE();
                    break;
                case "ProfileManagement":
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(67, 61);
                    this.mainProfileManagement1.BringToFront();
                    this.mainProfileManagement1.LOAD_PAGE();
                    break;
                case "ItemManagement":
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(134, 61);
                    this.mainItemManagement1.BringToFront();
                    this.mainItemManagement1.LOAD_PAGE();
                    break;
                case "Settings":
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(201, 61);
                    this.mainSettings1.BringToFront();
                    this.mainSettings1.LOAD_PAGE();
                    break;
                case "About":
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(364, 35);
                    this.mainAbout1.BringToFront();
                    this.mainAbout1.LOAD_PAGE();
                    break;
                default:
                    //Opens home
                    CHANGE_SIDE_BAR_POSITION_AND_SIZE(0, 61);
                    this.mainMain1.BringToFront();
                    break;
            }
        }
        #endregion
        #region SIDE BAR BUTTONS

        private void button_home_Click(object sender, EventArgs e)
        {
            LOAD_USER_CONTROL_PANEL("Home");
        }

        private void button_profile_management_Click(object sender, EventArgs e)
        {
            LOAD_USER_CONTROL_PANEL("ProfileManagement");
        }

        private void button_item_management_Click(object sender, EventArgs e)
        {
            LOAD_USER_CONTROL_PANEL("ItemManagement");
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            LOAD_USER_CONTROL_PANEL("Settings");
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            LOAD_USER_CONTROL_PANEL("About");
        }

        private void button_how_to_use_Click(object sender, EventArgs e)
        {
            //Run.OPEN_BROWSER_WITH_URL("https://justvice.github.io/");
            //MessageBox.Show("How to use");

        }

        #endregion
        #region SIDE BAR INDICATOR METHODS

        private void CHANGE_SIDE_BAR_POSITION_AND_SIZE(int y_location, int height)
        {
            CHANGE_SIDEBARINDICATOR_POSITION(y_location);
            CHANGE_SIDEBARINDICATOR_SIZE(height);
        }

        private void CHANGE_SIDEBARINDICATOR_POSITION(int y_position)
        {
            int x_position = panel_SideBarIndicator.Location.X;
            this.panel_SideBarIndicator.Location = new Point(x_position, y_position);
        }

        private void CHANGE_SIDEBARINDICATOR_SIZE(int height)
        {
            int x_size = this.panel_SideBarIndicator.Size.Width;
            this.panel_SideBarIndicator.Size = new Size(x_size, height);
        }

        #endregion
        #region DARK MODE
        public void CHANGE_DARK_MODE_TOGGLE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            if (IS_DARK_MODE_ACTIVATED)
            {
                this.ForeColor = Run.RETURN_BACKGROUND_COLOR_DARK();
            }
            else if (!IS_DARK_MODE_ACTIVATED)
            {
                this.ForeColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
            }
        }
        #endregion
        #region LANGUAGE METHODS

        //Changes the user interface language depending how the language
        //was stored inside userdata settings.
        public void UI_LANGUAGE_CONTROL_MAIN_ON_PROGRAM_LOAD()
        {
            string current_language_settled_on_memory = Memory.language;
            switch (current_language_settled_on_memory)
            {
                case "english":
                    button_about.Text = "About";
                    //button_home.Text = "Home";
                    button_item_management.Text = "Item management";
                    button_profile_management.Text = "Profile management";
                    button_how_to_use.Text = "How to use";
                    button_settings.Text = "Settings";
                    break;
                case "spanish":
                    button_about.Text = "Acerca";
                    //button_home.Text = "Home";
                    button_item_management.Text = "Administrar items";
                    button_profile_management.Text = "Administrar perfiles";
                    button_how_to_use.Text = "Cómo usar";
                    button_settings.Text = "Ajustes";
                    break;
            }
        }

        //Changes the user interface language when language is
        //changed on settings.
        public void UI_LANGUAGE_CONTROL_MAIN_TOGGLE()
        {
            string current_language_settled_on_memory = Memory.language;
            switch (current_language_settled_on_memory)
            {
                case "english":
                    button_about.Text = "Acerca";
                    //button_home.Text = "Home";
                    button_item_management.Text = "Administrar items";
                    button_profile_management.Text = "Administrar perfiles";
                    button_how_to_use.Text = "Cómo usar";
                    button_settings.Text = "Ajustes";
                    break;
                case "spanish":
                    button_about.Text = "About";
                    //button_home.Text = "Home";
                    button_item_management.Text = "Item management";
                    button_profile_management.Text = "Profile management";
                    button_how_to_use.Text = "How to use";
                    button_settings.Text = "Settings";
                    break;
            }
        }

        #endregion
    }
}
