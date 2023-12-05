import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SharedModule } from './shared/shared.module';
import { StoreComponent } from './store/store.component';
import { HomeModule } from './home/home.module';
import { FooterComponent } from './footer/footer.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'store', component: StoreComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule, HttpClientModule, RouterModule.forRoot(routes), SharedModule, HomeModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }