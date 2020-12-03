using System.Windows.Forms;
using App001.Logic;

namespace App001.UI
{
    public partial class MainMain : UserControl
    {
        public MainMain()
        {
            InitializeComponent();
        }

        public void LOAD_PAGE()
        {
            CHANGE_DARK_MODE_TOGGLE();
            CHANGE_LANGUAGE_TOGGLE();
        }

        #region DARK MODE

        private void CHANGE_DARK_MODE_TOGGLE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            switch (IS_DARK_MODE_ACTIVATED)
            {
                case true:
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_DARK();
                    this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_item_copied.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    break;
                case false:
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
                    this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_item_copied.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    break;
            }
        }

        #endregion

        #region LANGUAGE

        private void CHANGE_LANGUAGE_TOGGLE()
        {
            string current_language = Memory.language;
            switch (current_language)
            {
                case "spanish":
                    this.label_selected_profile.Text = "Perfil seleccionado: XXXX";
                    this.label_item_copied.Text = "ITEM COPIADO";
                    break;
                case "english":
                    this.label_selected_profile.Text = "Selected profile: XXXXXX";
                    this.label_item_copied.Text = "ITEM COPIED";
                    break;
            }
        }

        #endregion
    }
}
