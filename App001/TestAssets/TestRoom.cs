using System;
using System.Windows.Forms;
using App001.TestAssets;
using App001.Logic;
using App001.AppLogic;
using System.Data;

namespace App001.UI
{
    public partial class TestRoom : Form
    {
        public TestRoom()
        {
            InitializeComponent();
            aniadir_lore_a_lista();
        }

        private void button_agregar_texto_Click(object sender, EventArgs e)
        {
            add_listbox_text();
        }

        private void add_listbox_text()
        {
            string texto = this.textBox1.Text;
            ListTestObject tempObject = new ListTestObject();
            tempObject.name = texto;
            tempObject.logical_name = texto + "5555";
            this.listBox.Items.Add(tempObject);
            this.textBox1.Text = "";
        }

        private void aniadir_lore_a_lista()
        {
            ListTestObject temp = new ListTestObject("AAA","5555");
            this.listBox.Items.Add(temp);
            temp = new ListTestObject("BBB", "5555");
            this.listBox.Items.Add(temp);
            temp = new ListTestObject("CCC", "5555");
            this.listBox.Items.Add(temp);
        }

        private void click_on_list(object sender, MouseEventArgs e)
        {
            ListTestObject SELECTED_ITEM = this.listBox.SelectedItem as ListTestObject;
            if (SELECTED_ITEM != null)
                Console.WriteLine(SELECTED_ITEM.logical_name + " " + SELECTED_ITEM.name);
            else
                Console.Write("No object");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Run.CREATE_ID();
            MessageBox.Show(id);
            for (int i = 0; i < 100; i++)
            {
                Run.CREATE_ID();
            }
           
        }

        private void button_INI_FILE_Click(object sender, EventArgs e)
        {
            string program_path = Run.GET_PROGRAM_PATH();
            INIFile ini = new INIFile(program_path + "\\userdata.ini");
            ini.Write("User data", "language", "english");
            ini.Write("User data", "dark mode", "true");
            Console.WriteLine("Ini file written correctly.");
        }

        private void button_show_program_path_Click(object sender, EventArgs e)
        {
            string program_path = Run.GET_PROGRAM_PATH();
            MessageBox.Show(program_path);
        }

        private void button_read_ini_file_Click(object sender, EventArgs e)
        {
            string program_path = Run.GET_PROGRAM_PATH();
            INIFile ini = new INIFile(program_path + "\\userdata.ini");
            MessageBox.Show(ini.Read("User data","dark mode"));
        }

        private void button_read_sqlite_values_Click(object sender, EventArgs e)
        {
            SQLite s = new SQLite();
            DataSet DS = s.Fetch("select * from TEST_TABLE","Values from name read.");
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                string column_name_content = DS.Tables[0].Rows[i]["name"].ToString();
                Console.WriteLine(column_name_content);
            }
        }

        private void button_create_database_and_give_values_Click(object sender, EventArgs e)
        {
            SQLite s = new SQLite();
            s.Query("CREATE TABLE TEST_TABLE (name nvarchar(200));","Create table TEST_TABLE");
            s.Query("insert into TEST_TABLE (name)VALUES('ANA');","Insert name");
            s.Query("insert into TEST_TABLE (name)VALUES('ANA2');", "Insert name");
            s.Query("insert into TEST_TABLE (name)VALUES('ANA3');", "Insert name");
            s.Query("insert into TEST_TABLE (name)VALUES('ANA4');", "Insert name");
        }
    }
}

