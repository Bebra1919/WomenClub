using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomenClub.Model
{
    public class Users
    {
        private int user_id;
        private string name;
        private string surname;

       public Users(int id, string name, string surname) {
        this.user_id = id;
            this.name = name;
            this.surname = surname;
        }

        public int getId() { return user_id; }
        public string getName() { return name;}
        public string getSurname() {  return surname;}

    }
}
