import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'guy';
  num=0;
  element: number[]=[];
  times: Date[]=[];
  newEl(){
    this.element.push(this.element.length+1);
    this.times.push(new Date);
  }
  showTable=true;
}
