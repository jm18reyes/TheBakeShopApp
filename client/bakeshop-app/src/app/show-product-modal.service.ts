import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ShowProductModalService {
  showModal: boolean = false;
  constructor() { }
}
