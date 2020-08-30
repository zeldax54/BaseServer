using FluentMigrator;

namespace BaseServer.Migrations.DefaultDB
{
    [Migration(20200830004500)]
    public class DefaultDB_20200830_004500_Chats : AutoReversingMigration
    {
        public override void Up()
        {
                Create.Table("Chat").WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Identity().
                WithColumn("Ip").AsString(100).NotNullable().
                WithColumn("DateTime").AsDateTime().Nullable().
                WithColumn("Name").AsString(100).
                WithColumn("Msj").AsString();

        }
    }
}