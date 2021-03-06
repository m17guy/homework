    
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {elementcomponent} from './elements/elemen.component';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    elementcomponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }