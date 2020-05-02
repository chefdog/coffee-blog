import { Component, OnInit } from '@angular/core';
import { ArticleService } from 'src/app/services/article.service';
import { Article } from 'src/app/models/article.model';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent implements OnInit {
  article: Article;
  constructor(private readonly articleService: ArticleService) { }

  ngOnInit(): void {
    this.articleService.getArticle(1).subscribe(a => {
      if (a.model.length > 0) {
        this.article = a.model;
      }
    });
  }

}
