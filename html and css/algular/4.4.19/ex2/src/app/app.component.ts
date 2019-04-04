import { Component } from '@angular/core';
import { element, elementStart } from '@angular/core/src/render3';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ex2';
  elements: Number[] = [];
  newEl(){
    this.elements.push(this.elements.length+1)
  }
  getcolor(element){
    if(element%5===0)
    return 'blue';
    return element%2 === 0 ? 'green' :'red';
  }
}
