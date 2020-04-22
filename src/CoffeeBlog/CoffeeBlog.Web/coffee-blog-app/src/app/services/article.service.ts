import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Article } from '../models/article.model';
import { ARTICLES } from 'src/mocks/articles.mock';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor() { }

  getArticles(): Observable<Array<Article>> {
    return of(ARTICLES);
  }

  getArticle(id: number): Observable<Article> {
    const result = ARTICLES.filter(a => a.id === id);
    return of(result);
  }
}
