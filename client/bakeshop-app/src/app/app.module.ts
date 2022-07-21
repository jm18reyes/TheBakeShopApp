import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './products/products.component';
import { ProductModalComponent } from './products/product-modal/product-modal.component';
import { CoverCarouselComponent } from './cover-carousel/cover-carousel.component';
import { FooterComponent } from './footer/footer.component';
import { NavbarComponent } from './navbar/navbar.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { OurServicesComponent } from './our-services/our-services.component';
import { CareersComponent } from './careers/careers.component';
import { ContactComponent } from './contact/contact.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CartComponent } from './cart/cart.component';
import { ToastrModule } from 'ngx-toastr';
import { CheckoutComponent } from './checkout/checkout.component';
import { ShippingInfoComponent } from './checkout/shipping-info/shipping-info.component';
import { PaymentComponent } from './checkout/payment/payment.component';
import { StoresComponent } from './stores/stores.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    ProductModalComponent,
    CoverCarouselComponent,
    FooterComponent,
    NavbarComponent,
    WelcomeComponent,
    OurServicesComponent,
    CareersComponent,
    ContactComponent,
    CartComponent,
    CheckoutComponent,
    ShippingInfoComponent,
    PaymentComponent,
    StoresComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot()
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
