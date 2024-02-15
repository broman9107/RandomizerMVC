using Microsoft.Build.ObjectModelRemoting;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class PlayerModel
    {
        public int id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Position { get; set; }
    }
}
