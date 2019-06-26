
namespace BaseServer.Data.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Data.TemperatureData")]
    [BasedOnRow(typeof(Entities.TemperatureDataRow), CheckNames = true)]
    public class TemperatureDataColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [QuickFilter]
        public String UserUsername { get; set; }
        public DateTime Datetime { get; set; }
        public Double Value { get; set; }
    }
}