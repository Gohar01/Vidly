namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionInNameOfMembershipType : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Pay as You Go' WHERE DURATIONINMONTHS = 0");
        }
        
        public override void Down()
        {
        }
    }
}
