using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime RegDate { get; set; }
        public bool IsProfileShared { get; set; }
        public string Salt { get; set; }

    }
}
