import { Component, OnInit } from '@angular/core';
import { IstoreServices } from './our-services';

@Component({
  selector: 'app-our-services',
  templateUrl: './our-services.component.html',
  styleUrls: ['./our-services.component.css']
})
export class OurServicesComponent implements OnInit {

  storeServices: IstoreServices[] = [
    {
      id: "1",
      storeService: "Walk-in",
      serviceImgUrl: "https://unsplash.it/200/200"
    },
    {
      id: "2",
      storeService: "Pick-up",
      serviceImgUrl: "https://unsplash.it/200/200"
    },
    {
      id: "3",
      storeService: "Delivery",
      serviceImgUrl: "https://unsplash.it/200/200"
    },
    {
      id: "4",
      storeService: "Drive-Thru",
      serviceImgUrl: "https://unsplash.it/200/200"
    },
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
