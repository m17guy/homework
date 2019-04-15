import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'ex5';
  newform: FormGroup;
  ngOnInit() {
    this.newform=new FormGroup({
      'firstname':new FormControl("person",Validators.required),
      'familyname':new FormControl("smith"),
      'age':new FormControl(null),
      'email':new FormControl("fake.email@not-gmail.com",[Validators.required,Validators.email])
    });
  }
  onsubmit(){
    alert("hello "+this.newform.value.firstname+" "+this.newform.value.familyname+" as you are "+this.newform.value.age+" years old we have approved you for the site. a conformation email has been sent to "+this.newform.value.email)
  }
}

