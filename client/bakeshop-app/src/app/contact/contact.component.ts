import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm } from '@angular/forms';
import { ShowContactModalService } from './show-contact-modal.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  @ViewChild('contactForm') contactForm!: NgForm;

  showForm: boolean= true;
  email!: string;
  subject!: string;
  message!: string;
  constructor(public generateModal: ShowContactModalService,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    
  }

  onSubmit(){
    this.showForm = false

  }

  closeContactModal(){
    this.generateModal.showContactModal = false;
  }

}
