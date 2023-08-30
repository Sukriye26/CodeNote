using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormNotePad
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, UserName = "1", Password = "1" };
        public static List<Note> Notes = new List<Note>()
        {
            new Note{ Id =1, Description ="DATASTORE1"},
            new Note { Id = 2, Description = "DATASTORE2"}

        };

    }

    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

    }

    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
