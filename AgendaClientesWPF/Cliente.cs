using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Cliente
    {
        public string Cif { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Cliente(string cif, string name, string phone, string contact, string email)
        {
            Cif = cif;
            Name = name;
            Phone = phone;
            Contact = contact;
            Email = email;
        }
    }
}
