import { Component } from '@angular/core';
import { text } from '@angular/core/src/render3';
@Component({
    selector: 'element-Component',
    templateUrl: './element.component.html'
  })
  export class elementcomponent{
    colorSelected ='black';
    getcolor(){
     var col=Math.floor((Math.random() * 5)+1);
    switch(col){
      case 1:{
        this.colorSelected ='pink';
        break;
      }
      case 2:{
        this.colorSelected ='yellow';
        break;
      }
      case 3:{
        this.colorSelected ='red';
        break;
      }
      case 4:{
        this.colorSelected ='blue';
        break;
      }
      case 5:{
        this.colorSelected ='green';
        break;
      }
    }
  }
}