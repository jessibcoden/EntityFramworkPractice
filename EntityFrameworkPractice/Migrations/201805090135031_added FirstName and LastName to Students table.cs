namespace EntityFrameworkPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFirstNameandLastNametoStudentstable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "FirstName", c => c.String());
            AddColumn("dbo.Students", "LastName", c => c.String());
            DropColumn("dbo.Students", "StudentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentName", c => c.String());
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "FirstName");
        }
    }
}
