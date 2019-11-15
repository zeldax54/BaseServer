namespace BaseServer.Visitors {
    export interface VisitorsRow {
        Id?: number;
        Ip?: string;
        Coords?: string;
    }

    export namespace VisitorsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Ip';
        export const localTextPrefix = 'Visitors.Visitors';

        export declare const enum Fields {
            Id = "Id",
            Ip = "Ip",
            Coords = "Coords"
        }
    }
}

