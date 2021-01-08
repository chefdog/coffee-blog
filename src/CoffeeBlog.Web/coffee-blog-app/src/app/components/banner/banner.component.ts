import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';
import { Slide } from 'src/app/models/slide.model';
import { ImageService } from 'src/app/services/image.service';
import { ImageType } from 'src/app/models/image-type.enum';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  providers: [NgbCarouselConfig]
})
export class BannerComponent implements OnInit {
  slides: Array<Slide>;
  constructor(private readonly imageService: ImageService, config: NgbCarouselConfig) {
    config.interval = 10000;
    config.wrap = true;
    config.keyboard = false;
    config.pauseOnHover = false;
  }

  ngOnInit() {
    this.imageService.getImages().subscribe(result => {
      if (!result.didError) {
        console.log(result);
        this.slides = result.model;
      }
    });
  }
}
