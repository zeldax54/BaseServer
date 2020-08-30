
namespace BaseServer.Visitors.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Visitors.Visitors")]
    [BasedOnRow(typeof(Entities.VisitorsRow), CheckNames = true)]
    public class VisitorsForm
    {
        public String Ip { get; set; }
        public String Coords { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public DateTime DateTime { get; set; }


    }
}