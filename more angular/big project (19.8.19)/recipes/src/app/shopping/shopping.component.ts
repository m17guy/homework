import { Component, OnInit } from '@angular/core';
import {ingredient} from '../ingredients.model';

@Component({
  selector: 'app-shopping',
  templateUrl: './shopping.component.html',
  styleUrls: ['./shopping.component.css']
})
export class ShoppingComponent implements OnInit {

  allingredients=[new ingredient("orenge",5), new ingredient("fuck",0)]
  constructor() { }

  ngOnInit() {
  }
  takeaction(mystring){
    switch(mystring.asd){
      case("doadd"):
        this.allingredients.push(mystring.ingredient);
        break;
      case("dodelete"):
        this.allingredients.pop();
        break;
      case("doclear"):
        this.allingredients=[];
        break;
    }
  }

}
