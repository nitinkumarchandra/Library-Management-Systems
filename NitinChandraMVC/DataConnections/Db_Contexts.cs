using NitinChandraMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NitinChandraMVC.DataConnections
{
    public class Db_Contexts : DbContext
    {
        public Db_Contexts() : base("Data Source=DESKTOP-D58M58T;Initial Catalog=NitinKumarChandraMVC;Integrated Security=True")
        {

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<IssueBooks> IssueBooks { get; set; }
    }
}