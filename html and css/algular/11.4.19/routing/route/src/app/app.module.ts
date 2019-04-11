import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router'; //this
import { HeavenComponent } from './heaven/heaven.component';
import { HellComponent } from './hell/hell.component';
import { HomeComponent } from './home/home.component';
import { freemem } from 'os';

const appRoutes: Routes=[ //this
  {path: "home", component: HomeComponent},
  {path: "heaven", component: HeavenComponent},
  {path: "hell", component: HellComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    HeavenComponent,
    HellComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes) //this
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
