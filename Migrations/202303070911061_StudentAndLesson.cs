namespace UBYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAndLesson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TcNo", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "NameSurname", c => c.String());
            AddColumn("dbo.Students", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "TelephoneNo", c => c.Int());
            AddColumn("dbo.Students", "Mail", c => c.String());
            AddColumn("dbo.Students", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "Name");
            DropColumn("dbo.Students", "Surname");
            DropColumn("dbo.Students", "StudentNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentNo", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Surname", c => c.String());
            AddColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "DateTime");
            DropColumn("dbo.Students", "Mail");
            DropColumn("dbo.Students", "TelephoneNo");
            DropColumn("dbo.Students", "Number");
            DropColumn("dbo.Students", "NameSurname");
            DropColumn("dbo.Students", "TcNo");
        }
    }
}
