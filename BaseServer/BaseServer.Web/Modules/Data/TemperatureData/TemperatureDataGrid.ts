
namespace BaseServer.Data {

    @Serenity.Decorators.registerClass()
    export class TemperatureDataGrid extends Serenity.EntityGrid<TemperatureDataRow, any> {
        protected getColumnsKey() { return 'Data.TemperatureData'; }
        protected getDialogType() { return TemperatureDataDialog; }
        protected getIdProperty() { return TemperatureDataRow.idProperty; }
        protected getLocalTextPrefix() { return TemperatureDataRow.localTextPrefix; }
        protected getService() { return TemperatureDataService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}