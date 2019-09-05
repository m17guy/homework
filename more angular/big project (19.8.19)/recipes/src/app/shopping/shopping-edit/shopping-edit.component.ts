import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {ingredient} from '../../ingredients.model';

@Component({
  selector: 'app-shopping-edit',
  templateUrl: './shopping-edit.component.html',
  styleUrls: ['./shopping-edit.component.css']
})
export class ShoppingEditComponent implements OnInit {

  @Output() myaction=new EventEmitter<object>();
  prodact:ingredient;
  prodactname:string;
  prodactamount:number;
  constructor() { }

  ngOnInit() {
  }

  sendaction(st){
    this.myaction.emit({asd: st, ingredient: new ingredient(this.prodactname, this.prodactamount)});
  }
}
