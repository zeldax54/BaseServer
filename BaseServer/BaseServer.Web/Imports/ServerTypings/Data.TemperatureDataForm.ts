namespace BaseServer.Data {
    export interface TemperatureDataForm {
        UserId: Serenity.LookupEditor;
        Datetime: Serenity.DateEditor;
        Value: Serenity.DecimalEditor;
    }

    export class TemperatureDataForm extends Serenity.PrefixedContext {
        static formKey = 'Data.TemperatureData';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TemperatureDataForm.init)  {
                TemperatureDataForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(TemperatureDataForm, [
                    'UserId', w0,
                    'Datetime', w1,
                    'Value', w2
                ]);
            }
        }
    }
}

