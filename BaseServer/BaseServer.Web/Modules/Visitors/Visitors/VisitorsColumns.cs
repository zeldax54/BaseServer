
namespace BaseServer.Visitors.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Visitors.Visitors")]
    [BasedOnRow(typeof(Entities.VisitorsRow), CheckNames = true)]
    public class VisitorsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Ip { get; set; }
        public String Coords { get; set; }
    }
}