using System;
using System.Windows.Forms;
using App001.Logic;

namespace App001.UI
{
    public partial class MainAbout : UserControl
    {
        public MainAbout()
        {
            InitializeComponent();
        }

        public void LOAD_PAGE()
        {
            UI_LANGUAGE_CONTROL();
            CHANGE_DARK_MODE_TOGGLE();
        }

        #region LANGUAGE METHODS

        //Changes the user interface language
        private void UI_LANGUAGE_CONTROL()
        {
            string current_language_settled_on_memory = Memory.language;
            switch (current_language_settled_on_memory)
            {
                case "english":
                    label_about_title.Text = "About";
                    label_made_by.Text = "Made by";
                    button_webpage.Text = "Web page";
                    button_clipboard_board_webpage.Text = "Clipboard Board web page";
                    break;
                case "spanish":


                    label_about_title.Text = "Acerca";
                    label_made_by.Text = "Hecho por";
                    button_webpage.Text = "Página web";
                    button_clipboard_board_webpage.Text = "Página web de Clipboard Board";
                    break;
            }
        }

        #endregion

        #region DARK MODE

        private void CHANGE_DARK_MODE_TOGGLE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            switch (IS_DARK_MODE_ACTIVATED)
            {
                case true:
                    //Background
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_DARK();
                    //Buttons
                    this.button_clipboard_board_webpage.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_github.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_twitter.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_webpage.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_clipboard_board_webpage.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.button_github.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.button_twitter.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.button_webpage.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    //labels
                    this.label_about_title.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_links.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_made_by.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_vice_message.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                    this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                    break;
                case false:
                    //Background
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
                    //Buttons
                    this.button_clipboard_board_webpage.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_github.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_twitter.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_webpage.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_clipboard_board_webpage.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.button_github.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.button_twitter.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.button_webpage.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    //labels
                    this.label_about_title.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_links.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_made_by.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_vice_message.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                    this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                    break;
            }
        }

        #endregion

        #region button methods


        private void button_twitter_Click(object sender, EventArgs e)
        {
            Run.OPEN_BROWSER_WITH_URL("https://justvice.github.io/s/twitter/");
        }

        private void button_github_Click(object sender, EventArgs e)
        {
            Run.OPEN_BROWSER_WITH_URL("https://justvice.github.io/s/github-repos/");
        }

        private void button_webpage_Click(object sender, EventArgs e)
        {
            Run.OPEN_BROWSER_WITH_URL("https://justvice.github.io/");
        }

        private void button_clipboard_board_webpage_Click(object sender, EventArgs e)
        {
            Run.OPEN_BROWSER_WITH_URL("https://justvice.github.io/h/technology/CSharp/clipboard-board/");
        }


        #endregion

    }
}
