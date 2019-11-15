
namespace BaseServer.Visitors {

    @Serenity.Decorators.registerClass()
    export class VisitorsDialog extends Serenity.EntityDialog<VisitorsRow, any> {
        protected getFormKey() { return VisitorsForm.formKey; }
        protected getIdProperty() { return VisitorsRow.idProperty; }
        protected getLocalTextPrefix() { return VisitorsRow.localTextPrefix; }
        protected getNameProperty() { return VisitorsRow.nameProperty; }
        protected getService() { return VisitorsService.baseUrl; }

        protected form = new VisitorsForm(this.idPrefix);

    }
}