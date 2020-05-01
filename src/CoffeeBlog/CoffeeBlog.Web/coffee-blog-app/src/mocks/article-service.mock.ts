import { Observable, of } from 'rxjs';
import { Result } from 'src/app/models/result.model';
import { Message } from 'src/app/models/message.model';
import { ARTICLES } from './articles.mock';

export class ArticleServiceMock {
    result = new Result();

    getArticles(): Observable<Result> {
        this.result.data = ARTICLES;
        this.result.errors = new Array<Message>();
        this.result.warnings = new Array<Message>();
        this.result.info = new Array<Message>();
        return of(this.result);
    }

    getArticle(id: number): Observable<Result> {
        const data = ARTICLES.filter(a => a.id === id);
        this.result.data = data[0];
        this.result.errors = new Array<Message>();
        this.result.warnings = new Array<Message>();
        this.result.info = new Array<Message>();
        return of(this.result);
    }
}
