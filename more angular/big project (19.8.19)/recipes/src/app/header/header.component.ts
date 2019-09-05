import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  @Output() gotoshopping = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
  gotoRec(){
    this.gotoshopping.emit(false);
    console.log("gtrec");
  }
  gotoShop(){
    this.gotoshopping.emit(true);
    console.log("gtshop");
  }

}
