import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from '@angular/core';
import { Observable, throwError } from "rxjs";
import { IProduct } from "./Iproduct";
import { catchError, tap } from 'rxjs/operators';
import { CoverCarousel } from "../cover-carousel/cover-carousel";

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  private cakeUrl = 'assets/cakes.json';
  private carouselUrl = 'assets/cover-carousel.json';
  constructor(private http: HttpClient) { 

  }

  getCakes(): Observable<IProduct[]>{
    return this.http.get<IProduct[]>(this.cakeUrl).pipe( 
        tap(data => console.log('All', JSON.stringify(data))),
        catchError(this.handleError)
        
    );
    
  }

  getCarouselImages(): Observable<CoverCarousel[]>{
    return this.http.get<CoverCarousel[]>(this.carouselUrl).pipe( 
        tap(data => console.log('All', JSON.stringify(data))),
        catchError(this.handleError)
        
    );
    
  }

  private handleError(err: HttpErrorResponse){
    let errorMsg = '';
    if (err.error instanceof ErrorEvent){
        errorMsg = `An error occured ${err.error.message}`;
    }
    else{
        errorMsg = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMsg);
    return throwError(() => new Error(errorMsg));
  }

  
}
