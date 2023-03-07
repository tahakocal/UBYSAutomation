using System.Data.Entity;

namespace UBYS.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UbysAutomation;User ID=sqlUserName;Password=taha5353;")
        {

        }


        public virtual DbSet<Student> Students { get; set; }
    }
}
