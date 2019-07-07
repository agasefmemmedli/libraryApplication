using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Library_Managment.DAL;
using Library_Managment.Models;

namespace Library_Managment.Utilities
{
    
    public class Login
    {

         private readonly DAL.AppContext _context = new DAL.AppContext();
         public bool LoginCheck(string login, string password)
        {
            
            string realPass = _context.Administrators.Where(l => l.Login == login).Select(p => p.Password).First();

            if (realPass == password)
            {
                return true;
            }
            return false;
        }

    }
}
