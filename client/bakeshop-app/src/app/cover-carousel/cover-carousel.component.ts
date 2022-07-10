import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { CoverCarousel } from './cover-carousel';

@Component({
  selector: 'app-cover-carousel',
  templateUrl: './cover-carousel.component.html',
  styleUrls: ['./cover-carousel.component.css']
})
export class CoverCarouselComponent implements OnInit, OnDestroy {

  @Input() autoSlide: boolean = false;
  @Input() sliderInterval: number = 3000;
  selectedImage: number = 0;
  carouselIntervalID: any = 0;

  carouselImages: CoverCarousel[] = [
    {
      "id": "1",
      "imageName": "Strawberry Cake",
      "imageUrl": "assets/cake-strawberry-cover.jpg"
  },
  {
      "id": "2",
      "imageName": "Lemon Pie",
      "imageUrl": "assets/lemon-pie.jpg"
  },
  {
      "id": "3",
      "imageName": "Coffee Pastry",
      "imageUrl": "assets/pastry-coffee.jpg"
  }

  ];

  constructor() { }

  ngOnInit(): void {
    if(this.autoSlide){
      this.autoSlideImages();
    }
  }

  autoSlideImages(): void{
    this.carouselIntervalID= setInterval(()=>{
      this.onClickNext();
    },this.sliderInterval);
  }

  dotSelected(index: number){
    this.selectedImage = index;
  }

  onClickPrev(){
    if(this.selectedImage == 0){
      this.selectedImage = this.carouselImages.length -1;
    } else{
      this.selectedImage--;
    }
  }

  onClickNext(){
    if(this.selectedImage == this.carouselImages.length - 1){
      this.selectedImage = 0;
    } else {
      this.selectedImage++;
    }
  }

  ngOnDestroy(){
    clearInterval(this.carouselIntervalID);
  }
}
