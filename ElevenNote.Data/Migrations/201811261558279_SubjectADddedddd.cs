namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectADddedddd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Subject", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Subject");
        }
    }
}
