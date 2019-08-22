import { Component, OnInit } from '@angular/core';
import {WeatherService} from '../weather.service';
import {currentweather} from '../current-weather';
import {forecast} from '../forecast';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  cityforecast:forecast[]=[];
  myweather:currentweather;
  location:any;
  city:string;
  unitsInUse="C";
  unitsisC=true;
  constructor(private _weatherService: WeatherService) {}

  ngOnInit() {
    this._weatherService.localWeather("32.0853","34.7818",this.unitsisC).subscribe((data)=>{
      this.myweather = new currentweather(data.name,
                                          data.sys.country,
                                          data.main.temp,
                                          data.weather[0].icon,
                                          data.weather[0].description,
                                          data.main.humidity);
    });/*
    this._weatherService.forecast5geo("32.0853","34.7818",this.unitsisC).subscribe((data)=>{
      for(let i=0; i<data.list.length;i+=8){
        const temporary=new forecast( data.list[i].dt_txt.split(" ",1).toString().split("-").reverse().join("-"),
                                      data.list[i].main.temp,
                                      data.list[i].weather[0].icon,
                                      data.list[i].weather[0].description);
        this.cityforecast.push(temporary);
      }
    })
    for(let i=0; i<5;i++){
      this.cityforecast.pop();
    }*/

    navigator.geolocation.getCurrentPosition((pos)=>{
      this.location = pos.coords;
      const lat =this.location.latitude;
      const lon =this.location.longitude;
      this._weatherService.localWeather(lat,lon,this.unitsisC).subscribe((data)=>{
        this.myweather = new currentweather(data.name,
                                            data.sys.country,
                                            data.main.temp,
                                            data.weather[0].icon,
                                            data.weather[0].description,
                                            data.main.humidity);
      })
      this._weatherService.forecast5geo(lat,lon,this.unitsisC).subscribe((data)=>{
        for(let i=0; i<data.list.length;i+=8){
          const temporary=new forecast( data.list[i].dt_txt.split(" ",1).toString().split("-").reverse().join("-"),
                                        data.list[i].main.temp,
                                        data.list[i].weather[0].icon,
                                        data.list[i].weather[0].description);
          this.cityforecast.push(temporary);
        }
      })
    });
    for(let i=0; i<5;i++){
      this.cityforecast.pop();
    }
    
  }

  submit(){
    this._weatherService.searchweather(this.city,this.unitsisC).subscribe((data)=>{
      this.myweather = new currentweather(data.name,
                                          data.sys.country,
                                          data.main.temp,
                                          data.weather[0].icon,
                                          data.weather[0].description,
                                          data.main.humidity);
      });
      this._weatherService.forecast5(this.city,this.unitsisC).subscribe((data)=>{
        for(let i=0; i<data.list.length;i+=8){
          const temporary=new forecast( data.list[i].dt_txt.split(" ",1).toString().split("-").reverse().join("-"),
                                        data.list[i].main.temp,
                                        data.list[i].weather[0].icon,
                                        data.list[i].weather[0].description);
          this.cityforecast.push(temporary);
        }
      });
      for(let i=0; i<5;i++){
        this.cityforecast.pop();
      }
  }
  changeunit(){
    if(this.unitsInUse==="F"){
      this.unitsInUse="C";
    }
    else{
      if(this.unitsInUse==="C"){
        this.unitsInUse="F";
      }
    }
    this.unitsisC=!this.unitsisC;
    if(this.city==null){
      this.ngOnInit();
    }
    else{
      this.submit();
    }
  }


}
