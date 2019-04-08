import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {elementcomponent} from './elements/elemen.component';
import {FormsModule} from '@angular/forms';
import {shopcomponent} from './shop/shop.component';
import { AppComponent } from './app.component';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    elementcomponent,
    shopcomponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
