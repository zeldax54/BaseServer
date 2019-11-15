using FluentMigrator;

namespace BaseServer.Migrations.DefaultDB
{
    [Migration(20191115000700)]
    public class DefaultDB_20191115_000700_VisitorsDataAlter : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Visitors").
                AddColumn("Country").AsString(100).NotNullable().
                AddColumn("City").AsString(100);

        }
    }
}