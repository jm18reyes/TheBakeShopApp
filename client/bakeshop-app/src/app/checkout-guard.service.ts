import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot,UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { CartService } from './cart/cart.service';
@Injectable({
  providedIn: 'root'
})
export class CheckoutGuardService {

  grandTotal:number = 0;
  constructor(private router: Router,
    private cartService: CartService) { 
      this.cartService.getGrandTotal().subscribe((total) =>{
        this.grandTotal = total;
      });
    }
    
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      
      if(this.grandTotal <= 0){
        this.router.navigate(['/home']);
        return false;
      }
    return true;
  }
}
