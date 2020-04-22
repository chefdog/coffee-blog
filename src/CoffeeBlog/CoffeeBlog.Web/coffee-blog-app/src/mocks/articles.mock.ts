import { Article } from 'src/app/models/article.model';
import { ArticleType } from 'src/app/models/article-type.enum';


export const ARTICLES: Array<Article> = [
    {
         id: 1,
         lastModified: '21-01-04-2020',
         lastModifiedBy: 'testuser',
         title: 'Welkom',
         image: '../../assets/imgs/news/img-1.png',
         description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'
         + 'Praesent luctus laoreet mi, at elementum sem hendrerit vehicula.'
         + ' Integer est ante, venenatis eu nisl eu, fringilla tempor lacus.',
         articleType: ArticleType.article,
         tags: ['welcome', 'blog'],
         paragraphs: []
    }
];
