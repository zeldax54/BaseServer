﻿
namespace BaseServer.Visitors.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Visitors"), TableName("[dbo].[Visitors]")]
    [DisplayName("Visitors"), InstanceName("Visitors")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class VisitorsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Ip"), Size(100), NotNull, QuickSearch]
        public String Ip
        {
            get { return Fields.Ip[this]; }
            set { Fields.Ip[this] = value; }
        }

        [DisplayName("Coords"), Size(100), NotNull]
        public String Coords
        {
            get { return Fields.Coords[this]; }
            set { Fields.Coords[this] = value; }
        }

        [DisplayName("City"), Size(100), NotNull]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }
        [DisplayName("Country"), Size(100), NotNull]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("DateTime"), Size(100), NotNull]
        public DateTime? DateTime
        {
            get { return Fields.DateTime[this]; }
            set { Fields.DateTime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Ip; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VisitorsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Ip;
            public StringField Coords;
            public StringField City;
            public StringField Country;
            public DateTimeField DateTime;

        }
    }
}
