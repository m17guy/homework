import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-mytext',
  templateUrl: './mytext.component.html'
})
export class MytextComponent implements OnInit {

  constructor() { }
  @Input() sametext:string;
  ngOnInit() {
  }

}
