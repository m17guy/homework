import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ClipboardTextComponent } from './clipboard-text/clipboard-text.component';
import { CopyClipboardDirective } from './copyClipboard.directive';

@NgModule({
  declarations: [
    AppComponent,
    ClipboardTextComponent,
    CopyClipboardDirective
    ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
