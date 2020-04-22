import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Article } from '../models/article.model';
import { REVIEWS } from 'src/mocks/reviews.mock';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {

  constructor() { }

  getReviews(): Observable<Array<Article>> {
    return of(REVIEWS);
  }
}
