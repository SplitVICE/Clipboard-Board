
using App001.Logic;

namespace App001.AppLogic
{
    public class Language_strings
    {
        /////////////////////////////////////////////////
        //Language class. This class contains language changes.
        //Index 0 = English text.
        //Index 1 = Spanish text.
        /////////////////////////////////////////////////

        public static string[]
            profile_name_empty = { "You can not create a profile without a name."
                , "No puedes crear un prefil sin nombre." },
            profile_name_empty_title = { "No name given", "Perfil sin nombre" },
            profile_name_starts_with_space = { "A profile's name can not start with space"
                , "No es posible crear un pefil que comience con espacio." },
            profile_name_starts_with_space_title = { "Space detected", "Espacio detectado" },
            profile_edit_name_empty = {"Profiles can not have an empty name"
                ,"Los perfiles no pueden tener un nombre vacio."},
            profile_edit_name_empty_title = { "No name given", "Sin nombre dado" },
            profile_edit_name_with_space = {"A profile's name can not start with space."
                ,"Un perfil no puede empezar con un espacio."},
            new_element_name_starts_with_space = { "Space detected", "Espacio detectado" },
            profile_delete_content = {"Are you sure you want to delete the selected profile?\r\nThis action cannot be undone.",
        "¿Esta seguro/a que desea eliminar el perfil seleccionado?\r\nEsta acción no puede deshacerse."},
            profile_delete_content_title = { "Delete profile", "Eliminar perfil" },
            selected_profile = { "Selected profile: ", "Perfil seleccionado: " },
            new_item_name_empty = { "Items can not have an empty name.", "Los items no pueden tener un nombre vacío." },
            new_item_name_empty_title = { "Item without name", "Item sin nombre" },
            new_item_name_starts_with_space = { "Items's names can not start with space."
                ,"Los items no pueden tener un nombre que comience con espacio."},
            new_item_content_empty = { "The item content cannot be empty.", "El contenido del item no puede estar vacío." },
            new_item_content_empty_title = { "Item content empty", "Contenido del item vacío" },
            new_item_content_starts_with_space = { "Item content cannot start with space.","El contenido del item no puede estar vacío."};

        public static int indexer()
        {
            if (Memory.language == "english")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
