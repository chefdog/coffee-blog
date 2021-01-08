import { Message } from './message.model';

export class ResultList {
    message: string;
    didError: boolean;
    errorMessage: string;
    pageSize: number;
    pageNumber: number;
    model: any;
}
