using FluentMigrator;

namespace BaseServer.Migrations.DefaultDB
{
    [Migration(20191115004500)]
    public class DefaultDB_20191115_004500_VisitorsDataAlterDate : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Visitors").
                AddColumn("DateTime").AsDateTime().Nullable();
              
        }
    }
}