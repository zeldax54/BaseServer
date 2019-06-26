
namespace BaseServer.Data {

    @Serenity.Decorators.registerClass()
    export class TemperatureDataDialog extends Serenity.EntityDialog<TemperatureDataRow, any> {
        protected getFormKey() { return TemperatureDataForm.formKey; }
        protected getIdProperty() { return TemperatureDataRow.idProperty; }
        protected getLocalTextPrefix() { return TemperatureDataRow.localTextPrefix; }
        protected getService() { return TemperatureDataService.baseUrl; }

        protected form = new TemperatureDataForm(this.idPrefix);

    }
}