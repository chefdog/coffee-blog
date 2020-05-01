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
  errors: Array<Message>;
  constructor(private readonly articleService: ArticleService) { }

  ngOnInit() {
    this.articleService.getArticlesByType(ArticleType.review).subscribe(result => {
      if (result.errors.length > 0) {
        this.errors = result.errors;
        return;
      }

      if (result.data.length > 0) {
        this.news = result.data.filter(n => n.articleType === ArticleType.review);
      }
    });
  }
}
