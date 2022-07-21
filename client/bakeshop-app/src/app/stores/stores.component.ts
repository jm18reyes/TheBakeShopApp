import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { MapService } from '../map.service';

@Component({
  selector: 'app-stores',
  templateUrl: './stores.component.html',
  styleUrls: ['./stores.component.css']
})
export class StoresComponent implements OnInit, OnDestroy {
    cityStore: string = "Calapan City";
    fullAddress: string = "2nd flr Quezon Bldg Calapan City";
    contactNumber: string = "(0917)654-4044";
    waitingId!:any;
    showMapButtonSub!:Subscription;
    mapShown:boolean = false;
    constructor(private mapService: MapService,
      private router: Router, private activatedRoute: ActivatedRoute) {
      

    }

  showMap(){
    
    this.mapShown = true;
    window.location.reload();
  }
  ngOnInit(): void {
    this.showMapButtonSub = this.mapService.getButtonStatus().subscribe((status)=>{
      this.mapShown = status;
    });
  }

  ngOnDestroy(): void {
    this.mapService.setButtonStatus(false);
    this.showMapButtonSub.unsubscribe();
  }
}
