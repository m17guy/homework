import { Component, OnInit } from '@angular/core';
import {WeatherService} from '../weather.service';
import {forecast} from '../forecast';

@Component({
  selector: 'app-forecast',
  templateUrl: './forecast.component.html',
  styleUrls: ['./forecast.component.css']
})
export class ForecastComponent implements OnInit {

  cityforecast:forecast[]=[];
  constructor(private _weatherService: WeatherService) { }

  ngOnInit() {
    this._weatherService.forecast5("london").subscribe((data)=>{
      for(let i=0; i<data.list.length;i+=8){
        const temporary=new forecast( data.list[i].dt_txt.split(" ",1).toString().split("-").reverse().join("-"),
                                      data.list[i].main.temp,
                                      data.list[i].weather[0].icon,
                                      data.list[i].weather[0].description,
                                      data.city.name);
        this.cityforecast.push(temporary);
      }
    });
  }

}
