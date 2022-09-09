import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchItemService {

  searchedItem: string = '';
  searchedItemObservable = new BehaviorSubject<any>([]);
  constructor() { 

  }

  getSearchedItem(){
    
    return this.searchedItemObservable.asObservable();

  }

  setSearchedItem(item:string){
    console.log(`set Search: ${item}`);
    this.searchedItem = item;
    this.searchedItemObservable.next(this.searchedItem);
  }


}
