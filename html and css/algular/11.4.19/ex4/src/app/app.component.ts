import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ex4';
  counter:number[]=[1];
  addrow(){
    this.counter.push(this.counter.length+1);
  }
}
