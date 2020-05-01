import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Article } from '../models/article.model';
import { ARTICLES } from 'src/mocks/articles.mock';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ArticleType } from '../models/article-type.enum';
import { Result } from '../models/result.model';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {
  rootUrl = 'api/articles';
  constructor(private http: HttpClient) { }

  getArticles(): Observable<Result> {
    return this.http.get<Result>(this.rootUrl);
  }

  getArticle(id: number): Observable<Result> {
    return this.http.get<Result>(`${this.rootUrl}/${id}`);
  }

  getArticlesByType(articleType: ArticleType): Observable<Result> {
    return this.http.get<Result>(this.rootUrl);
    // return this.http.get<Result>(`${this.url}/${articleType}`);
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
