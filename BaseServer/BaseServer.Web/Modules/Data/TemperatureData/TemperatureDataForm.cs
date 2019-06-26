
namespace BaseServer.Data.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
     

    [FormScript("Data.TemperatureData")]
    [BasedOnRow(typeof(Entities.TemperatureDataRow), CheckNames = true)]
    public class TemperatureDataForm
    {
        [LookupEditor("Administration.Users")]
        public Int32 UserId { get; set; }
        public DateTime Datetime { get; set; }
        public Double Value { get; set; }
    }
}