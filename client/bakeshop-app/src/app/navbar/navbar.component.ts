import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CartService } from '../cart/cart.service';
import { SearchItemService } from '../search-item.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  public totalCartItems: number = 0;
  searchedItem: string = '';
  showMenu: boolean = false;
  constructor(private cartService: CartService,
    private searchItemService: SearchItemService,
    private router: Router) { }

  ngOnInit(): void {
    this.cartService.getProducts().subscribe(item =>{
      this.totalCartItems = item.length;
    });

    
  }

  onSearch(){
    console.log('clicked');
    this.router.navigate(['/cakes']);
    this.searchItemService.setSearchedItem(this.searchedItem);
  }

  onSearchKey(){
    console.log('entered');
  }

}
