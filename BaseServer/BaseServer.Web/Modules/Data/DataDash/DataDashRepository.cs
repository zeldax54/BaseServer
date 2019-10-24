
namespace BaseServer.Data.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using MyRow = Entities.TemperatureDataRow;

    public class DataDashRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

      
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            //Temporal Ramdom Data for now
            var temp = new List<MyRow>();
            var random = new Random();
            for (int i = 0; i < 60; i++)
            {
                temp.Add(new MyRow()
                {
                    Id = i,
                    Datetime = DateTime.Now,
                    Value = random.Next(0,1)
                });

            }
            return new ListResponse<MyRow>()
            {
                Entities = temp
            };
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}