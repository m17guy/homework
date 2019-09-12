import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-clipboard-text',
  templateUrl: './clipboard-text.component.html',
  styleUrls: ['./clipboard-text.component.css']
})
export class ClipboardTextComponent {
@Input('clipboardText') text: string;
  constructor() { }



}
