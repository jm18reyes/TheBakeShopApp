import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ShowContactModalService {
  showContactModal: boolean = false;
  constructor() { }
}
