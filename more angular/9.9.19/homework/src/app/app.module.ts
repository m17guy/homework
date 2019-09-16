import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { GettextdirectiveDirective } from './gettextdirective.directive';
import { MytextComponent } from './mytext/mytext.component';

@NgModule({
  declarations: [
    AppComponent,
    GettextdirectiveDirective,
    MytextComponent,
    
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
