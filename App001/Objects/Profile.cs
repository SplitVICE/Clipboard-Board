using App001.Logic;
using System.Windows.Forms;

namespace App001.Objects
{

    /// <summary>
    /// Profiles that keep your item's info. This object categorizes your items
    /// by the name you gave to the profile.
    /// </summary>

    public class Profile
    {
        public string profile_name { get; set; }
        public int profile_id { get; set; }
        private int max_id_random_number = 999999999;


        public Profile()
        {
            this.profile_id = Run.GENERATE_RANDOM_NUMBER(1, max_id_random_number);
        }

        public Profile(string profile_name)
        {
            this.profile_id = Run.GENERATE_RANDOM_NUMBER(1, max_id_random_number);
            this.profile_name = profile_name;
        }

        public override string ToString()
        {
            return this.profile_name;
        }

        public string sortened_profile_name()
        {
            string return_value = "";
            int max_length = 34;
            if (this.profile_name.Length >= max_length)
            {
                int cont = 0;
                foreach (char c in this.profile_name)
                {
                    return_value += "" + c;
                    cont++;
                    if (cont == max_length - 1)
                        break;
                }
            }
            else
            {
                return this.profile_name;
            }
            return return_value + "...";
        }

    }
}
