import { Injectable } from '@angular/core';
import { InMemoryDbService, RequestInfo  } from 'angular-in-memory-web-api';
import { Article } from '../models/article.model';
import { ARTICLES } from 'src/mocks/articles.mock';
import { Result } from '../models/result.model';
import { Message } from '../models/message.model';


@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService implements InMemoryDbService {
  createDb(reqInfo?: RequestInfo) {
    let returnType  = 'object';
    const articles = new Result();
    articles.data = ARTICLES;
    articles.errors = new Array<Message>();
    articles.warnings = new Array<Message>();
    articles.info = new Array<Message>();
    console.log(reqInfo);
    if (reqInfo) {
      const body = reqInfo.utils.getJsonBody(reqInfo.req) || {};
      if (body.clear === true) {
        articles.data.length = 0;
      }

      // 'returnType` can be 'object' | 'observable' | 'promise'
      returnType = body.returnType || 'object';
    }

    return {articles};
  }

  // Overrides the genId method to ensure that a article always has an id.
  genId(articles: Result): number {
    return articles.data.length > 0 ? Math.max(...articles.data.map(article => article.id)) + 1 : 11;
  }
}
