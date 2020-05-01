import { MessageType } from './message-type.enum';

export class Message {
    id: number;
    content: string;
    messageType: MessageType;
}
