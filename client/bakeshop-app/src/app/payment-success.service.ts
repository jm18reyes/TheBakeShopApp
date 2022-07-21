import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PaymentSuccessService {

  isAddressValid: boolean = false;
  addressValidEvent = new BehaviorSubject<any>([]);
  constructor() { }

  getAddressConfirmation(){
    return this.addressValidEvent.asObservable();
  }

  addressConfirmed(confirmation: boolean){
    this.isAddressValid = confirmation;
    this.addressValidEvent.next(this.isAddressValid);
  }
}
