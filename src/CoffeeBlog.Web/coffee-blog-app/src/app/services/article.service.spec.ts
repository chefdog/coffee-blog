import { TestBed, inject } from '@angular/core/testing';
import { HttpTestingController, HttpClientTestingModule } from '@angular/common/http/testing';
import { ArticleService } from './article.service';
import { ARTICLES } from 'src/mocks/articles.mock';
import { Result } from '../models/result.model';

describe('ArticleService', () => {

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ArticleService]
    });
  });

  afterEach(inject([HttpTestingController], (httpMock: HttpTestingController) => {
    httpMock.verify();
  }));

  it('should be created', () => {
    const service = TestBed.get(ArticleService);
    expect(service).toBeTruthy();
  });

  it('expects service to fetch data',
    inject([HttpTestingController, ArticleService], (httpMock: HttpTestingController, service: ArticleService) => {
        const mockArticles = ARTICLES;
        // We call the service
        service.getArticles().subscribe((newsResult: Result) => {
          expect(newsResult.data.length).toBe(4);
        });
        // We set the expectations for the HttpClient mock
        const req = httpMock.expectOne('api/articles');
        expect(req.request.method).toEqual('GET');
        // Then we set the fake data to be returned by the mock
        req.flush({data: mockArticles});
      })
  );

});
