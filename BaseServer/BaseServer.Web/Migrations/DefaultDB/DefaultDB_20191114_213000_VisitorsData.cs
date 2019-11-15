using FluentMigrator;

namespace BaseServer.Migrations.DefaultDB
{
    [Migration(20191114213000)]
    public class DefaultDB_20191114_213000_VisitorsData : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Visitors").WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Identity().
                WithColumn("Ip").AsString(100).NotNullable().
                WithColumn("Coords").AsString(100);

        }
    }
}