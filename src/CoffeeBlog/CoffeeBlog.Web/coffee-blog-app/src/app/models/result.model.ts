import { Message } from './message.model';

export class Result {
    data: any;
    errors: Array<Message>;
    warnings: Array<Message>;
    info: Array<Message>;
}
