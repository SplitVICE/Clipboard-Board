using App001.Logic;

namespace App001.Objects
{

    /// <summary>
    /// Class of the items. This object keep the content information you
    /// store and ask for to be copied to clipboard when you need it.
    /// </summary>

    public class Item : Profile
    {
        ////////////////////////////////////
        ///Item variables
        public int item_id { get; set; }
        public string item_name { get; set; }
        public string item_content { get; set; }

        /////////////////////////////////////
        ///Constructors

        public Item()
        {
            this.item_id = Run.GENERATE_RANDOM_NUMBER(1,99999);
        }

        public Item(string item_name, string item_content)
        {
            this.item_id = Run.GENERATE_RANDOM_NUMBER(1, 99999);
            this.item_name = item_name;
            this.item_content = item_content;
        }

        public Item(string item_name, string item_content, int parent_profile_id)
        {
            this.item_id = Run.GENERATE_RANDOM_NUMBER(1, 99999);
            this.item_name = item_name;
            this.item_content = item_content;
            base.profile_id = parent_profile_id;
        }

        public override string ToString()
        {
            return this.item_name;
        }
    }
}
