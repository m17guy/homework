import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {cupcomponent} from './cup.component/cup.component';
import {tableeecomponent} from './tableee.component/tableee.component';

@NgModule({
  declarations: [
    AppComponent,
    cupcomponent,
    tableeecomponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
