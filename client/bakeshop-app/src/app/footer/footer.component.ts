import { Component, OnInit } from '@angular/core';
import { ShowContactModalService } from '../contact/show-contact-modal.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  constructor(
    public generateContactModal: ShowContactModalService) { }

  ngOnInit(): void {
  }

  openContactModal(): void{
    
    this.generateContactModal.showContactModal=true;
  }

}
