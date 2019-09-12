import { Component, OnInit, Output, EventEmitter, ViewChild, ElementRef } from '@angular/core';
import {ingredient} from '../../ingredients.model';

@Component({
  selector: 'app-shopping-edit',
  templateUrl: './shopping-edit.component.html',
  styleUrls: ['./shopping-edit.component.css']
})
export class ShoppingEditComponent implements OnInit {

  @Output() myaction=new EventEmitter<object>();
@ViewChild('productName') productName: ElementRef;
@ViewChild('productAmount') productAmount: ElementRef;

  prodact_name:string;
  prodact_amount:number;
  constructor() { }

  ngOnInit() {
  }

  sendaction(st){
    this.prodact_name=this.productName.nativeElement.value
    this.prodact_amount=this.productAmount.nativeElement.value;
    this.myaction.emit({string: st, ingredient: new ingredient(this.prodact_name, this.prodact_amount)});
  }
}
