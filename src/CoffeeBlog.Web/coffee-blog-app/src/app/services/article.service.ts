import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Article } from '../models/article.model';
import { ARTICLES } from 'src/mocks/articles.mock';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { ArticleType } from '../models/article-type.enum';
import { Result } from '../models/result.model';
import { environment } from 'src/environments/environment';
import { ResultList } from '../models/result-list.model';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {
  rootUrl = `${environment.webApi}/blog`;
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  getArticles(): Observable<ResultList> {
    return this.http.get<ResultList>(this.rootUrl);
  }

  getArticle(id: number): Observable<Result> {
    return this.http.get<Result>(`${this.rootUrl}/${id}`);
  }

  getArticlesByType(articleType: ArticleType): Observable<ResultList> {
    return this.http.get<ResultList>(`${this.rootUrl}/${articleType}`);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  private log(message: string) {
    console.log(`HeroService: ${message}`);
  }
}
