import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  searchText: string = "";
  gameslist:string[]=[
    "bastion",
    "tranzister",
    "pair",
    "borderlands",
    "borderlands 2",
    "borderlands the pre-secoule",
    "borderlands 3",
    "xcom",
    "just couse",
    "zoma",
    "enter the gungen",
    "crises",
    "diablo",
    "might and magic",
    "civ 5"
  ];
  check(game){
    if(game.indexOf(this.searchText)>-1){
      return true;
    }
    return false;
  }

}
