import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})
export class HelloComponent {
  mynames:string[]=["guy"];
  addname(){
    this.mynames.push("guy");
    if(this.mynames.length>4){
      this.mynames.splice(1)
    }
  }
}
