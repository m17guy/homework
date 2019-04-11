import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-heaven',
  templateUrl: './heaven.component.html',
  styleUrls: ['./heaven.component.css']
})
export class HeavenComponent{
  favprer:string[]=[];
  newprer:string="";
  addfav(){
    this.favprer.push(this.newprer)
    this.newprer="";
  }
}
