import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CareersComponent } from './careers/careers.component';
import { CartComponent } from './cart/cart.component';
import { OurServicesComponent } from './our-services/our-services.component';
import { ProductsComponent } from './products/products.component';
import { WelcomeComponent } from './welcome/welcome.component';

const routes: Routes = [
  {path: 'home',component:WelcomeComponent},
  {path: 'services',component:OurServicesComponent},
  {path: 'careers',component:CareersComponent},
  {path: 'cakes',component:ProductsComponent},
  {path: 'cart',component:CartComponent},
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  {path: '**', redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
