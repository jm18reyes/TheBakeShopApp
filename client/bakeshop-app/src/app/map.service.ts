import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MapService {
  showMapButtonClicked:boolean = false;
  showMapButton = new BehaviorSubject<any>([]);
  constructor() { }

  getButtonStatus(){
    return this.showMapButton.asObservable();
  }

  setButtonStatus(status: boolean){
    this.showMapButtonClicked = status;
    this.showMapButton.next(this.showMapButtonClicked);
  }
}
