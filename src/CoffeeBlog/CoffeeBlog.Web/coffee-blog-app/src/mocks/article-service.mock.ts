import { Observable, of } from 'rxjs';
import { Result } from 'src/app/models/result.model';
import { ARTICLES } from './articles.mock';

export class ArticleServiceMock {
    result = new Result();

    getArticles(): Observable<Result> {
        this.result.model = ARTICLES;
        return of(this.result);
    }

    getArticle(id: number): Observable<Result> {
        const data = ARTICLES.filter(a => a.id === id);
        this.result.model = data[0];
        return of(this.result);
    }
}
