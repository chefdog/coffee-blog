import { Article } from 'src/app/models/article.model';
import { ArticleType } from 'src/app/models/article-type.enum';

export const ARTICLES: Array<Article> = [
   {
        id: 11,
        lastModified: '21-01-04-2020',
        lastModifiedBy: 'testuser',
        title: 'Article title 01',
        image: '../../assets/imgs/news/img-1.png',
        description: 'My article description',
        articleType: ArticleType.review,
        tags: ['review', 'coffee'],
        paragraphs: [
            {
                articleId: 11,
                paragraph: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'
                + 'Praesent luctus laoreet mi, at elementum sem hendrerit vehicula.'
                + ' Integer est ante, venenatis eu nisl eu, fringilla tempor lacus.'
            }
        ]
   },
   {
    id: 12,
    lastModified: '21-01-03-2020',
     lastModifiedBy: 'testuser',
     title: 'Article title 02',
     image: '../../assets/imgs/news/img-1.png',
     description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
     articleType: ArticleType.review,
     tags: ['review', 'coffee'],
     paragraphs: [
         {
             articleId: 12,
             paragraph: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'
              + 'Praesent luctus laoreet mi, at elementum sem hendrerit vehicula.'
              + ' Integer est ante, venenatis eu nisl eu, fringilla tempor lacus.'
         }
     ]
    },
    {
        id: 13,
        lastModified: '21-01-03-2020',
        lastModifiedBy: 'testuser',
        title: 'Article title 03',
        image: '../../assets/imgs/news/img-1.png',
        description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
        articleType: ArticleType.review,
        tags: ['review', 'coffee'],
        paragraphs: [
            {
                articleId: 13,
                paragraph: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'
                + 'Praesent luctus laoreet mi, at elementum sem hendrerit vehicula.'
                + ' Integer est ante, venenatis eu nisl eu, fringilla tempor lacus.'
            }
        ]
    }
];
