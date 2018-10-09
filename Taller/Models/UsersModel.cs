using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datalayer;

namespace Taller.Models
{
   
    public class UsersModel
    {
        private escuelaEntities dbs = new escuelaEntities();
        public List<students> GetStudents()
        {
            var students = dbs.students.ToList();
            return students;
        }
    }
}