import { Directive,
  HostListener,
  HostBinding,
  Input, } from '@angular/core';

  @Directive({
    selector: '[appGettextdirective]'
  })
  export class GettextdirectiveDirective {
    
  theval:string
  @HostBinding("value") mytext:string;

  constructor() { }

  @HostListener("click") myonclick(eventData: Event) {
    console.log(this.mytext);
    if( this.mytext=="red"){
      this.mytext="blue";
    }
    else
    this.mytext="red";
  }
}
