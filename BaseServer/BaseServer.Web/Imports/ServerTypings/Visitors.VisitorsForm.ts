namespace BaseServer.Visitors {
    export interface VisitorsForm {
        Ip: Serenity.StringEditor;
        Coords: Serenity.StringEditor;
    }

    export class VisitorsForm extends Serenity.PrefixedContext {
        static formKey = 'Visitors.Visitors';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!VisitorsForm.init)  {
                VisitorsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(VisitorsForm, [
                    'Ip', w0,
                    'Coords', w0
                ]);
            }
        }
    }
}

