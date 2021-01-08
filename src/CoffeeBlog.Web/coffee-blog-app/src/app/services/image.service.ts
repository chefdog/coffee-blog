import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { ResultList } from '../models/result-list.model';
import { Result } from '../models/result.model';
import { ImageType } from '../models/image-type.enum';

@Injectable({
  providedIn: 'root'
})
export class ImageService {
  rootUrl = `${environment.webApi}/image`;
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  getImages(): Observable<ResultList> {
    return this.http.get<ResultList>(this.rootUrl);
  }

  getImage(id: number): Observable<Result> {
    return this.http.get<Result>(`${this.rootUrl}/${id}`);
  }

  getImagesByType(imageType: ImageType): Observable<ResultList> {
    return this.http.get<ResultList>(`${this.rootUrl}/${imageType}`);
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
