namespace BaseServer.Membership {
    export interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Email?: string;
    }
}

