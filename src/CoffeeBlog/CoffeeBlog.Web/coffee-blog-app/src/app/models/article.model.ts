import { ArticleType } from './article-type.enum';
import { Paragraph } from './paragraph.model';

export class Article {
    id: number;
    lastModified: string;
    lastModifiedBy: string;
    title: string;
    image: string;
    description: string;
    articleType: ArticleType;
    tags: Array<string>;
    paragraphs: Array<Paragraph>;
 }
