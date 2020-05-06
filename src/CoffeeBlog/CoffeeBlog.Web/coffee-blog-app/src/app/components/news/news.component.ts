import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article.model';
import { ArticleService } from 'src/app/services/article.service';
import { Message } from 'src/app/models/message.model';
import { ArticleType } from 'src/app/models/article-type.enum';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html'
})
export class NewsComponent implements OnInit {
  news: Array<Article>;
  errors: Array<string>;
  constructor(private readonly articleService: ArticleService) { }

  ngOnInit() {
    this.articleService.getArticlesByType(ArticleType.review).subscribe(result => {
      if (result.errorMessage) {
        this.errors = new Array<string>();
        this.errors.push(result.errorMessage);
        return;
      }

      if (result.model.length > 0) {
        this.news = result.model;
      }
    });
  }
}
