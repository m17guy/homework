import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { serverscomponent } from './servers/servers.component';
import { dogscomponent } from './dogs/dog.component';
import { AlertComponent } from './alert/alert.component';
import { SuccessComponent } from './success/success.component';

@NgModule({
  declarations: [
    AppComponent,
    serverscomponent,
    dogscomponent,
    AlertComponent,
    SuccessComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
