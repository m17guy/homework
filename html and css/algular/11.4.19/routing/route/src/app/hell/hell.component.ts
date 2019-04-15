import { Component, OnInit, OnChanges } from '@angular/core';

@Component({
  selector: 'app-hell',
  templateUrl: './hell.component.html',
  styleUrls: ['./hell.component.css']
})
export class HellComponent implements OnChanges{
  torcher="";
  col:string="black";
  red:number=0;
  green:number=0;
  blue:number=0;
  counter:number=0;
  ngOnChanges(): void {
    if(this.torcher.indexOf("red")>=0){
      this.red+=255;
      this.green+=0;
      this.blue+=0;
      this.counter++;
      alert("red");
    }
    alert("red");
    this.red/=this.counter;
    this.green/=this.counter;
    this.blue/=this.counter;
    this.col="("+this.red+","+this.green+","+this.blue+")";
    this.counter=0;
    this.red=0;
    this.green=0;
    this.blue=0;
  }
}
