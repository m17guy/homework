import { Component, Input } from '@angular/core';
import { element, elementStart } from '@angular/core/src/render3';
import {elementcomponent} from './elements/elemen.component';
import {shopcomponent} from './shop/shop.component';
import { from } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ex3';
  elements: elementcomponent[] = [];
  newEl(){
    this.elements.push(new elementcomponent);
  }

  inputt="";
  shoping=[];
  moreshoping(){
    this.shoping.push(1); // [] - [1] - [1,1] - [1,1,1]
  }
}
