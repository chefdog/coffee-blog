import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article.model';
import { ArticleService } from 'src/app/services/article.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {
  news: Array<Article>;
  constructor(private readonly articleService: ArticleService) { }

  ngOnInit() {
    this.articleService.getArticles().subscribe(articles => this.news = articles);
  }
}
