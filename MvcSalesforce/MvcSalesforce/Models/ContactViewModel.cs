using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class ContactViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string AccountName { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}