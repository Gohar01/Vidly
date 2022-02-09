namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Pay as You GO' WHERE DURATIONINMONTHS = 0");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Monthly' WHERE DURATIONINMONTHS = 1");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Quaterly' WHERE DURATIONINMONTHS = 3");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Yearly' WHERE DURATIONINMONTHS = 12");
        }
        
        public override void Down()
        {
        }
    }
}
