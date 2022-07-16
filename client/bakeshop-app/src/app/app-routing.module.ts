import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CareersComponent } from './careers/careers.component';
import { OurServicesComponent } from './our-services/our-services.component';
import { ProductsComponent } from './products/products.component';
import { WelcomeComponent } from './welcome/welcome.component';

const routes: Routes = [
  {path: 'Home',component:WelcomeComponent},
  {path: 'Services',component:OurServicesComponent},
  {path: 'Careers',component:CareersComponent},
  {path: 'Cakes',component:ProductsComponent},
  {path: '', redirectTo: 'Home', pathMatch: 'full'},
  {path: '**', redirectTo: 'Home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
