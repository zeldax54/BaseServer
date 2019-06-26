namespace BaseServer.Data {
    export namespace DataDashService {
        export const baseUrl = 'Data/DataDash';

        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TemperatureDataRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            List = "Data/DataDash/List"
        }

        [
            'List'
        ].forEach(x => {
            (<any>DataDashService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

