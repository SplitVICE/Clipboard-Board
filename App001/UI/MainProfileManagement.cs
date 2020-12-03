using System.Drawing;
using System.Windows.Forms;
using App001.Logic;
using App001.AppLogic;
using App001.Objects;
using System;

namespace App001.UI
{
    public partial class MainProfileManagement : UserControl
    {
        private Profile SELECTED_PROFILE_ON_LIST;

        public MainProfileManagement()
        {
            InitializeComponent();
        }

        public void LOAD_PAGE()
        {
            UI_LANGUAGE_CONTROL();
            CHANGE_DARK_LIGHT_MODE();
            FILL_LIST_WITH_LODADED_PROFILE_ITEMS();
            CLEAR_ALL_TEXT_BOXES();
            LOAD_SELECTED_PROFILE_NAME_ON_SELECTED_PROFILE_LABEL();
        }

        private void FILL_LIST_WITH_LODADED_PROFILE_ITEMS()
        {
            this.listBox_profile_list.Items.Clear();
            foreach (Profile p in Memory.PROFILE_LIST)
            {
                this.listBox_profile_list.Items.Add(p);
            }
        }

        private void CLEAR_ALL_TEXT_BOXES()
        {
            this.textBox_profile_name_create.Text = "";
            this.textBox_set_new_name.Text = "";
        }

        private void LOAD_SELECTED_PROFILE_NAME_ON_SELECTED_PROFILE_LABEL()
        {
            this.label_selected_profile.Text = Run.LOAD_SELECTED_PROFILE_NAME();
        }

        #region MAIN METHODS

        #region CREATE NEW PROFILE

        private void button_profile_name_create_Click(object sender, System.EventArgs e)
        {
            CREATE_NEW_PROFILE();
        }

        private void CREATE_NEW_PROFILE()
        {
            bool IS_THE_TEXTBOX_NOT_EMPTY = Run.IS_THE_TEXTBOX_NOT_EMPTY(this.textBox_profile_name_create.Text,
                Language_strings.profile_name_empty[Language_strings.indexer()],
                Language_strings.profile_name_empty_title[Language_strings.indexer()],
                MessageBoxIcon.Warning,
                Language_strings.profile_name_starts_with_space[Language_strings.indexer()],
                Language_strings.profile_name_starts_with_space_title[Language_strings.indexer()]
                , MessageBoxIcon.Warning);
            if (IS_THE_TEXTBOX_NOT_EMPTY)
            {
                SET_NEW_PROFILE_METHOD_TREE();
            }
        }

        private void SET_NEW_PROFILE_METHOD_TREE()
        {
            Profile profile_to_add = BUILD_NEW_PROFILE(this.textBox_profile_name_create.Text);
            Memory.SQLITE.SAVE_NEW_PROFILE(profile_to_add);
            SAVE_PROFILE_INSIDE_PROFILE_LIST_MEMORY(profile_to_add);
            SET_NEW_PROFILE_INSIDE_LIST(profile_to_add);
            this.textBox_profile_name_create.Text = "";
        }

        private void SET_NEW_PROFILE_INSIDE_LIST(Profile profile_to_add)
        {
            this.listBox_profile_list.Items.Add(profile_to_add);
        }

        private Profile BUILD_NEW_PROFILE(string profile_name)
        {
            return new Profile(profile_name);
        }

        private void SAVE_PROFILE_INSIDE_PROFILE_LIST_MEMORY(Profile profile_to_add)
        {
            Memory.PROFILE_LIST.Add(profile_to_add);
        }

        private void textBox_profile_name_create_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CREATE_NEW_PROFILE();
            }
        }

        #endregion

        #region EDIT PROFILE NAME

        private void SET_SELECTED_ITEM_NAME_INSIDE_EDIT_TEXTBOX()
        {
            if (this.SELECTED_PROFILE_ON_LIST != null)
            {
                this.textBox_set_new_name.Text = this.SELECTED_PROFILE_ON_LIST.profile_name;
            }
        }

        private void button_edit_name_Click(object sender, EventArgs e)
        {
            EDIT_PROFILE_NAME_TREE_METHOD();
        }

        private void EDIT_PROFILE_NAME_TREE_METHOD()
        {
            if (IS_A_PROFILE_ON_LIST_SELECTED_AND_IS_THE_TEXT_INSIDE_TEXTBOX_NOT_EMPTY_OR_STARTS_WITH_SPACE())
            {
                Profile temp_profile = this.SELECTED_PROFILE_ON_LIST;
                UPDATE_SELECTED_PROFILE_NAME_ON_DATABASE(temp_profile);
                UPDATE_SELECTED_PROFILE_NAME_ON_MEMORY(temp_profile);
                FILL_LIST_WITH_LODADED_PROFILE_ITEMS();
                this.textBox_set_new_name.Text = "";
                UI_LANGUAGE_CONTROL();
            }
        }

        private bool IS_A_PROFILE_ON_LIST_SELECTED_AND_IS_THE_TEXT_INSIDE_TEXTBOX_NOT_EMPTY_OR_STARTS_WITH_SPACE()
        {
            if (this.SELECTED_PROFILE_ON_LIST != null && Run.IS_THE_TEXTBOX_NOT_EMPTY(this.textBox_set_new_name.Text,
                Language_strings.profile_edit_name_empty[Language_strings.indexer()],
                Language_strings.profile_edit_name_empty_title[Language_strings.indexer()],
                MessageBoxIcon.Warning,
                Language_strings.profile_edit_name_with_space[Language_strings.indexer()],
                Language_strings.new_element_name_starts_with_space[Language_strings.indexer()],
                MessageBoxIcon.Warning))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UPDATE_SELECTED_PROFILE_NAME_ON_DATABASE(Profile profile_to_update)
        {
            string new_name = this.textBox_set_new_name.Text;
            int profiles_id_to_update = profile_to_update.profile_id;
            string query = "UPDATE PROFILE " +
                "SET profile_name = '" + new_name + "' " +
                "WHERE program_id = " + profiles_id_to_update;
            Memory.SQLITE.Query(query, "Profile " + profile_to_update.profile_name + " updated to " + new_name + " on database: OK.");
        }

        private void UPDATE_SELECTED_PROFILE_NAME_ON_MEMORY(Profile profile_to_update)
        {
            string new_name = this.textBox_set_new_name.Text;
            for (int i = 0; i < Memory.PROFILE_LIST.Count; i++)
            {
                if (Memory.PROFILE_LIST[i].profile_id == profile_to_update.profile_id)
                {
                    Memory.PROFILE_LIST[i].profile_name = new_name;
                    break;
                }
            }
            Run.CONSOLE_MESSAGE("Profile " + profile_to_update.profile_name + " updated to " + new_name + " on memory: OK.");
        }

        private void textBox_set_new_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EDIT_PROFILE_NAME_TREE_METHOD();
            }
        }

        #endregion

        #region DELETE PROFILE

        private void button_delete_selected_profile_Click(object sender, EventArgs e)
        {
            if (this.SELECTED_PROFILE_ON_LIST != null)
            {
                DELETE_PROFILE_TREE_METHOD();
            }
        }

        private void DELETE_PROFILE_TREE_METHOD()
        {
            bool USER_SURE_ABOUT_DELETING_PROFILE = IS_USER_SURE_ABOUT_DELETING_SELECTED_PROFILE();
            if (USER_SURE_ABOUT_DELETING_PROFILE)
            {
                Profile profile_to_delete = this.SELECTED_PROFILE_ON_LIST;
                DELETE_PROFILE_FROM_DATABASE(profile_to_delete);
                DELETE_PROFILE_FROM_MEMORY(profile_to_delete);
                UI_CHANGES_AFTER_DELETE_A_PROFILE();
            }
        }

        private void UI_CHANGES_AFTER_DELETE_A_PROFILE()
        {
            FILL_LIST_WITH_LODADED_PROFILE_ITEMS();
            CLEAR_ALL_TEXT_BOXES();
            UI_LANGUAGE_CONTROL();
        }

        private void DELETE_PROFILE_FROM_DATABASE(Profile profile_to_delete)
        {
            string query = "DELETE FROM PROFILE WHERE program_id = " + profile_to_delete.profile_id;
            string query_message = "Profile " + profile_to_delete.profile_name + " deleted from database.";
            Memory.SQLITE.Query(query, query_message);
        }

        private void DELETE_PROFILE_FROM_MEMORY(Profile profile_to_delete)
        {
            for (int n = 0; n < Memory.PROFILE_LIST.Count; n++)
            {
                if (Memory.PROFILE_LIST[n].profile_id == profile_to_delete.profile_id)
                {
                    Memory.PROFILE_LIST.Remove(profile_to_delete);
                    Run.CONSOLE_MESSAGE("Profile " + profile_to_delete.profile_name + " deleted from memory.");
                    break;
                }
            }
        }

        private bool IS_USER_SURE_ABOUT_DELETING_SELECTED_PROFILE()
        {
            return Run.ASK_USER(Language_strings.profile_delete_content[Language_strings.indexer()]
                , Language_strings.profile_delete_content_title[Language_strings.indexer()]);
        }

        private void SET_SELECTED_PROFILE_TO_DETELE_LABEL()
        {
            if (this.SELECTED_PROFILE_ON_LIST != null)
            {
                if (Memory.language == "english")
                    this.label_no_selected_profile.Text = "- Selected: " + this.SELECTED_PROFILE_ON_LIST.sortened_profile_name();
                else
                    this.label_no_selected_profile.Text = "- Seleccionado: " + this.SELECTED_PROFILE_ON_LIST.sortened_profile_name();
            }
        }

        #endregion

        #endregion

        #region LANGUAGE METHODS

        private void UI_LANGUAGE_CONTROL()
        {
            string current_language_settled_on_memory = Memory.language;
            switch (current_language_settled_on_memory)
            {
                case "english":
                    label_edit_selected_profile.Text = "Edit selected profile";
                    label_selected_profile.Text = "Selected profile: XXX";
                    label_create_new_profile.Text = "Create new profile";
                    label_delete_profile.Text = "Delete profile";
                    label_set_new_name.Text = "Set new name:";
                    label_select_the_profile_to_delete.Text = "Select the profile to delete";
                    label_delete_profile.Text = "Delete profile";
                    label_profile_name.Text = "Profile name:";
                    label_no_selected_profile.Text = "- No selected profile";
                    button_profile_name_create.Text = "Create";
                    button_edit_name.Text = "Edit name";
                    button_delete_selected_profile.Text = "Delete selected profile";
                    button_set_this_profile_as_current.Text = "Set selected profile as current one";
                    MOVE_LABELS("english");
                    break;
                case "spanish":
                    label_edit_selected_profile.Text = "Editar perfil seleccionado";
                    label_selected_profile.Text = "Perfil seleccionado: XXX";
                    label_create_new_profile.Text = "Crear nuevo perfil";
                    label_delete_profile.Text = "Eliminar perfil";
                    label_set_new_name.Text = "Nuevo nombre:";
                    label_select_the_profile_to_delete.Text = "Selecciona un perfil para borrar";
                    label_delete_profile.Text = "Eliminar perfil";
                    label_profile_name.Text = "Nombre del perfil:";
                    label_no_selected_profile.Text = "- Sin perfil seleccionado";
                    button_profile_name_create.Text = "Crear";
                    button_edit_name.Text = "Editar nombre";
                    button_delete_selected_profile.Text = "Borrar perfil seleccionado";
                    button_set_this_profile_as_current.Text = "Establecer perfil seleccionado";
                    MOVE_LABELS("spanish");
                    break;
            }
        }

        private void MOVE_LABELS(string language)
        {
            if (language == "spanish")
            {
                int label_profile_name_y_position = this.label_profile_name.Location.Y;
                this.label_profile_name.Location = new Point(40, label_profile_name_y_position);
                ///
                int label_set_new_name_y_position = this.label_set_new_name.Location.Y;
                this.label_set_new_name.Location = new Point(48, label_set_new_name_y_position);
            }
            else if (language == "english")
            {
                this.label_profile_name.Location = new Point(59, 88);
                this.label_set_new_name.Location = new Point(52, 207);
            }
        }

        #endregion

        #region DARK MODE

        private void CHANGE_DARK_LIGHT_MODE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            if (IS_DARK_MODE_ACTIVATED)
            {
                //Background color
                this.BackColor = Run.RETURN_BACKGROUND_COLOR_DARK();
                //Labels
                this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                this.label_separator_3.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_create_new_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_profile_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_edit_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_set_new_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_delete_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_select_the_profile_to_delete.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.label_no_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                //Buttons
                this.button_delete_selected_profile.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.button_edit_name.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.button_profile_name_create.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.button_set_this_profile_as_current.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                //Buttons text
                this.button_delete_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.button_edit_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.button_profile_name_create.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                this.button_set_this_profile_as_current.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                //Listbox
                this.listBox_profile_list.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                this.listBox_profile_list.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
            }
            else
            {
                //background color
                this.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
                //labels
                this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                this.label_separator_3.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_create_new_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_profile_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_edit_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_set_new_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_delete_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_select_the_profile_to_delete.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.label_no_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                //Buttons
                this.button_delete_selected_profile.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                this.button_edit_name.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                this.button_profile_name_create.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                this.button_set_this_profile_as_current.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                //Buttons text
                this.button_delete_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.button_edit_name.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.button_profile_name_create.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                this.button_set_this_profile_as_current.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                //Listbox
                this.listBox_profile_list.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
                this.listBox_profile_list.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
            }
        }

        #endregion

        private void listBox_profile_list_Click(object sender, System.EventArgs e)
        {
            this.SELECTED_PROFILE_ON_LIST = this.listBox_profile_list.SelectedItem as Profile;
            SET_SELECTED_ITEM_NAME_INSIDE_EDIT_TEXTBOX();
            SET_SELECTED_PROFILE_TO_DETELE_LABEL();
        }

        #region SELECT NEW PROFILE AS CURRENT METHODS
        private void button_set_this_profile_as_current_Click(object sender, EventArgs e)
        {
            if (this.SELECTED_PROFILE_ON_LIST != null)
            {
                SAVE_SELECTED_PROFILE_AS_CURRENT_INSIDE_MEMORY_AND_INI_FILE(this.SELECTED_PROFILE_ON_LIST);
                UI_CHANGES_AFTER_SELECTING_A_PROFILE_AS_CURRENT(this.SELECTED_PROFILE_ON_LIST);
            }
        }

        private void SAVE_SELECTED_PROFILE_AS_CURRENT_INSIDE_MEMORY_AND_INI_FILE(Profile list_selected_profile)
        {
            Memory.INI_FILE.SAVE_USER_DATA_ON_MEMORY_AND_INIFILE(Memory.language, Memory.DARK_MODE_ACTIVATED, list_selected_profile);
        }

        private void UI_CHANGES_AFTER_SELECTING_A_PROFILE_AS_CURRENT(Profile list_selected_profile)
        {
            this.label_selected_profile.Text = Language_strings.selected_profile[Language_strings.indexer()] + list_selected_profile.sortened_profile_name();
        }
        #endregion

    }
}

