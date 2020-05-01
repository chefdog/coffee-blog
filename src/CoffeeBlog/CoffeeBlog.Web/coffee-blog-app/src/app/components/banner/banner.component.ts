import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';
import { Slide } from 'src/app/models/slide.model';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css']
})
export class BannerComponent implements OnInit {
  slides: Array<Slide>;
  constructor(config: NgbCarouselConfig) {
    // customize default values of carousels used by this component tree
    config.wrap = true;
    config.keyboard = false;
    config.pauseOnHover = false;
  }

  ngOnInit() {
    this.slides = new Array<Slide>();
    const slide = new Slide();
    slide.id = 1;
    slide.title = 'Koffie lekkerr';
    slide.image = '../../assets/images/slider/slider-1.jpg';
    slide.description = 'mijn fantastische omschrijving';
    this.slides.push(slide);

    slide.id = 2;
    slide.title = 'Koffie lekkerr 2';
    slide.description = 'mijn fantastische omschrijving 2';
    slide.image = '../../assets/images/slider/slider-2.jpg';
    this.slides.push(slide);

    slide.id = 3;
    slide.title = 'Koffie lekkerr 3';
    slide.description = 'mijn fantastische omschrijving 3';
    slide.image = '../../assets/images/slider/slider-3.jpg';
    this.slides.push(slide);
  }
}
