import { Component, OnInit } from '@angular/core';
import {Recipe} from "../recipe.model";
import { from } from 'rxjs';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent{
  recipes=[new Recipe("test","this is a test","https://food.fnr.sndimg.com/content/dam/images/food/fullset/2018/5/14/1/WU1902_Italian-Chicken-Sheet-Pan-Supper_s4x3.jpg.rend.hgtvcom.826.620.suffix/1526332485385.jpeg"),
  new Recipe("second test","more description","favicon.ico")];
 
  constructor() { }

}
