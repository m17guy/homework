import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'a ng stuff test';
  name="guy";
  showp=true;
  counter=[];
  bclicked(){
    this.showp=!this.showp;
    this.counter.push(this.counter.length);
  }
}
