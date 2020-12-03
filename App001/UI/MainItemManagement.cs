using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App001.Logic;
using App001.AppLogic;
using App001.Objects;

namespace App001.UI
{
    public partial class MainItemManagement : UserControl
    {
        private Item SELECTED_ITEM;
        public MainItemManagement()
        {
            InitializeComponent();
        }

        #region SETTINGS

        public void LOAD_PAGE()
        {
            CHANGE_LANGUAGE_TOGGLE();
            CHANGE_DARK_MODE_TOGGLE();
            LOAD_SELECTED_PROFILE_NAME_ON_SELECTED_PROFILE_LABEL();
            LOAD_ITEMS_ON_MEMORY_AND_FILL_ITEMS_LIST();
        }

        private void LOAD_SELECTED_PROFILE_NAME_ON_SELECTED_PROFILE_LABEL()
        {
            this.label_selected_profile.Text = Run.LOAD_SELECTED_PROFILE_NAME();
        }

        private void LOAD_ITEMS_ON_MEMORY_AND_FILL_ITEMS_LIST()
        {
                this.listBox_item_list.Items.Clear();
                foreach (Item i in Memory.ITEM_LIST)
                {
                    this.listBox_item_list.Items.Add(i);
                }
        }

        #endregion

        #region SAVE NEW ITEM
        private void button_create_new_item_Click(object sender, EventArgs e)
        {
            SAVE_NEW_ITEM_TREE();
        }
        private void SAVE_NEW_ITEM_TREE()
        {
            string new_item_name = this.textBox_item_name_create.Text;
            string new_item_content = this.textBox_item_content_create.Text;
            if (IS_THERE_A_NEW_ITEM_NAME_TYPED(new_item_name)
                && IS_THERE_A_NEW_ITEM_CONTENT_TYPED(new_item_content))
            {
                Item new_item_to_save = BUILD_ITEM_TO_SAVE(new_item_name, new_item_content, Memory.SELECTED_PROFILE.profile_id);
                SAVE_NEW_ITEM_INSIDE_MEMORY(new_item_to_save);
                SAVE_NEW_ITEM_INSIDE_DATABASE(new_item_to_save);
                SAVE_NEW_ITEM_UI_CHANGES(new_item_to_save);
            }
        }

        private bool IS_THERE_A_NEW_ITEM_NAME_TYPED(string new_item_name)
        {
            return Run.IS_THE_TEXTBOX_NOT_EMPTY(new_item_name,
                Language_strings.new_item_name_empty[Language_strings.indexer()],
                Language_strings.new_item_name_empty_title[Language_strings.indexer()],
                MessageBoxIcon.Warning,
                Language_strings.new_item_name_starts_with_space[Language_strings.indexer()],
                Language_strings.new_element_name_starts_with_space[Language_strings.indexer()],
                MessageBoxIcon.Warning);
        }

        private bool IS_THERE_A_NEW_ITEM_CONTENT_TYPED(string new_item_name)
        {
            return Run.IS_THE_TEXTBOX_NOT_EMPTY(new_item_name,
                Language_strings.new_item_content_empty[Language_strings.indexer()],
                Language_strings.new_item_content_empty_title[Language_strings.indexer()],
                MessageBoxIcon.Warning,
                Language_strings.new_item_content_starts_with_space[Language_strings.indexer()],
                Language_strings.new_element_name_starts_with_space[Language_strings.indexer()],
                MessageBoxIcon.Warning);
        }
        private Item BUILD_ITEM_TO_SAVE(string new_item_name, string new_item_content, int parent_profile_id)
        {
            return new Item(new_item_name, new_item_content, parent_profile_id);
        }
        private void SAVE_NEW_ITEM_INSIDE_MEMORY(Item item_to_save)
        {
            Memory.ITEM_LIST.Add(item_to_save);
            Run.CONSOLE_MESSAGE("Item " + item_to_save + " saved on memory.");
        }
        private void SAVE_NEW_ITEM_INSIDE_DATABASE(Item item_to_save)
        {
            String query = "INSERT INTO ITEM (program_id" +
                ", item_name" +
                ", item_content" +
                ", parent_profile_id)" +
                "VALUES(" + item_to_save.item_id +
                ", '" + item_to_save.item_name + "'" +
                ", '" + item_to_save.item_content +"'"+
                "," + item_to_save.profile_id + "); ";
            Memory.SQLITE.Query(query, "Item " + item_to_save.item_name + " saved on database.");
        }
        private void SAVE_NEW_ITEM_UI_CHANGES(Item item_to_save)
        {
            SAVE_NEW_ITEM_INSIDE_LIST(item_to_save);
            SET_TEXT_ON_TEXTBOX_ITEM_CREATE_NAME_AND_CONTENT("","");
        }

        private void SAVE_NEW_ITEM_INSIDE_LIST(Item item_to_save)
        {
            this.listBox_item_list.Items.Add(item_to_save);
        }

        private void SET_TEXT_ON_TEXTBOX_ITEM_CREATE_NAME_AND_CONTENT(string item_name,string item_content)
        {
            this.textBox_item_name_create.Text = item_name;
            this.textBox_item_content_create.Text = item_content;
        }
        #endregion
        
        #region EDIT ITEM
        private void EDIT_ITEM_LIST_CLICK()
        {

        }
        #endregion

        #region LANGUAGE METHODS

        private void CHANGE_LANGUAGE_TOGGLE()
        {
            string CURRENT_LANGUAGE = Memory.language;
            switch (CURRENT_LANGUAGE)
            {
                case "spanish":
                    //Labels
                    this.label_selected_profile.Text = "Perfil seleccionado: XXX";
                    this.label_create_new_item.Text = "Crear nuevo item";
                    this.label_edit_item.Text = "Editar item";
                    this.label_edit_or_delete_item.Text = "Editar o borrar item";
                    this.label_item_content_1.Text = "Contenido del item:";
                    this.label_item_content_2.Text = "Contenido del item:";
                    this.label_item_name_1.Text = "Nombre del item:";
                    this.label_item_name_2.Text = "Nombre del item:";
                    //Buttons text
                    this.button_create_new_item.Text = "Crear nuevo item";
                    this.button_delete_selected_item.Text = "Borrar item seleccionado";
                    this.button_save_changes.Text = "Guardar cambios";
                    //Changes textbox size because longer label text
                    //NAME ITEM ELEMENTS
                    //Size: 466. Position: 96.
                    int x_spanish_width_name_item = 466, y_spanish_width_name_item = 20;
                    this.textBox_item_name_create.Size = new Size(x_spanish_width_name_item, y_spanish_width_name_item);
                    //Changes position of textbox
                    int x_spanish_position_name_item = 96, y_spanish_position_name_item = this.textBox_item_name_create.Location.Y;
                    this.textBox_item_name_create.Location = new Point(x_spanish_position_name_item, y_spanish_position_name_item);
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //CONTENT ITEM ELEMENTS
                    //Size: 457. Position: 105.
                    int x_spanish_width_content_item = 457, y_spanish_width_content_item = 20;
                    this.textBox_item_content_create.Size = new Size(x_spanish_width_content_item, y_spanish_width_content_item);
                    //Changes position of textbox
                    int x_spanish_position_content_item = 105, y_spanish_position_content_item = this.textBox_item_content_create.Location.Y;
                    this.textBox_item_content_create.Location = new Point(x_spanish_position_content_item, y_spanish_position_content_item);
                    break;
                case "english":
                    //Labels
                    this.label_selected_profile.Text = "Selected profile: XXX";
                    this.label_create_new_item.Text = "Create new item";
                    this.label_edit_item.Text = "Edit item";
                    this.label_edit_or_delete_item.Text = "Edit or delete item";
                    this.label_item_content_1.Text = "Item content:";
                    this.label_item_content_2.Text = "Item content:";
                    this.label_item_name_1.Text = "Item name:";
                    this.label_item_name_2.Text = "Item name:";
                    //Buttons text
                    this.button_create_new_item.Text = "Create new item";
                    this.button_delete_selected_item.Text = "Delete selected item";
                    this.button_save_changes.Text = "Save changes";
                    //Changes textbox size because shorter label text
                    //NAME ITEM ELEMENTS
                    //Size: 480. Position: 82;77.
                    int x_english_width_name_item = 480, y_english_width_name_item = 20;
                    this.textBox_item_name_create.Size = new Size(x_english_width_name_item, y_english_width_name_item);
                    //Changes position of textbox
                    int x_english_position_name_item = 82, y_english_position_name_item = this.textBox_item_name_create.Location.Y;
                    this.textBox_item_name_create.Location = new Point(x_english_position_name_item, y_english_position_name_item);
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //CONTENT ITEM ELEMENTS
                    //Size: 480; 20. Location: 82; 103
                    int x_english_width_content_item = 480, y_english_width_content_item = 20;
                    this.textBox_item_content_create.Size = new Size(x_english_width_content_item, y_english_width_content_item);
                    //Changes position of textbox
                    int x_english_position_content_item = 82, y_english_position_content_item = this.textBox_item_content_create.Location.Y;
                    this.textBox_item_content_create.Location = new Point(x_english_position_content_item, y_english_position_content_item);
                    break;
            }
        }

        #endregion

        #region DARK MODE METHODS

        private void CHANGE_DARK_MODE_TOGGLE()
        {
            bool IS_DARK_MODE_ACTIVATED = Memory.DARK_MODE_ACTIVATED;
            switch (IS_DARK_MODE_ACTIVATED)
            {
                case true:
                    //background
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_DARK();
                    //labels
                    this.label_create_new_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_edit_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_edit_or_delete_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_item_content_1.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_item_content_2.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_item_name_1.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_item_name_2.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                    this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                    this.label_separator_3.ForeColor = Run.RETURN_SEPARATOR_COLOR_DARK();
                    this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    //buttons backcolor
                    this.button_create_new_item.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_delete_selected_item.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    this.button_save_changes.BackColor = Run.RETURN_BUTTON_COLOR_DARK();
                    //buttons text color
                    this.button_create_new_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.button_delete_selected_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    this.button_save_changes.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_DARK();
                    break;
                case false:
                    //background
                    this.BackColor = Run.RETURN_BACKGROUND_COLOR_LIGHT();
                    //labels
                    this.label_create_new_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_edit_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_edit_or_delete_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_item_content_1.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_item_content_2.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_item_name_1.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_item_name_2.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.label_separator_1.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                    this.label_separator_2.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                    this.label_separator_3.ForeColor = Run.RETURN_SEPARATOR_COLOR_LIGHT();
                    this.label_selected_profile.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    //buttons backcolor
                    this.button_create_new_item.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_delete_selected_item.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    this.button_save_changes.BackColor = Run.RETURN_BUTTON_COLOR_LIGHT();
                    //buttons text color
                    this.button_create_new_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.button_delete_selected_item.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    this.button_save_changes.ForeColor = Run.RETURN_LABEL_AND_TEXT_COLOR_LIGHT();
                    break;
            }
        }


        #endregion

        private void listBox_item_list_Click(object sender, EventArgs e)
        {
            EDIT_ITEM_LIST_CLICK();
        }
    }
}
