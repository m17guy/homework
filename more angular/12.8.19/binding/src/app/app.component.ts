import { Component, NgModule } from '@angular/core';
import { from } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'binding';
  username="";
  emptyname=true;
  
  onUpdateusername(event: Event){
    //this.username=(<HTMLInputElement>event.target).value;
    this.emptyname=(this.username==="");
  }
  press(){
    this.username="";
    this.emptyname=true;
  }
}
