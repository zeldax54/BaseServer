
namespace BaseServer.Visitors {

    @Serenity.Decorators.registerClass()
    export class VisitorsGrid extends Serenity.EntityGrid<VisitorsRow, any> {
        protected getColumnsKey() { return 'Visitors.Visitors'; }
        protected getDialogType() { return VisitorsDialog; }
        protected getIdProperty() { return VisitorsRow.idProperty; }
        protected getLocalTextPrefix() { return VisitorsRow.localTextPrefix; }
        protected getService() { return VisitorsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}