import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Article } from '../models/article.model';
import { ARTICLES } from 'src/mocks/artilces.mock';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor() { }

  getArticles(): Observable<Array<Article>> {
    return of(ARTICLES);
  }
}
