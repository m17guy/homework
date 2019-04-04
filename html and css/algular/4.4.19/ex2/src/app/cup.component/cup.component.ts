import { Component } from '@angular/core';
import { text } from '@angular/core/src/render3';
@Component({
    selector: 'cup-component',
    templateUrl: './cup.component.html'
  })
  export class cupcomponent{
      text=false;
      answer:string="";
    cupgame(x){
        x===Math.floor(Math.random() * Math.floor(3)+1)? this.answer="you got it right":this.answer="WRONG!";
        this.text=!this.text;
    }
  }