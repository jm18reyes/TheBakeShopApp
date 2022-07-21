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
      serviceImgUrl: "assets/walk-in.jpg"
    },
    {
      id: "2",
      storeService: "Pick-up",
      serviceImgUrl: "assets/pickup.jpg"
    },
    {
      id: "3",
      storeService: "Delivery",
      serviceImgUrl: "assets/delivery.jpg"
    },
    {
      id: "4",
      storeService: "Drive-Thru",
      serviceImgUrl: "assets/drive-thru.jpg"
    },
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
