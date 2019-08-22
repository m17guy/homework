import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { currentweather } from './current-weather';

@Injectable()
export class WeatherService {

  tempunits:string;
  apiKey= 'fc0c4e1ec49d0c022df6519574a1a2ca';

  constructor(public http: HttpClient) { }
  

  localWeather(lat:string, lon:string, units:boolean){
    this.checkunits(units)
    return this.http.get("https://api.openweathermap.org/data/2.5/weather?lat="+lat+"&lon="+lon+"&appid="+this.apiKey+"&units="+this.tempunits);
  }
  forecast5geo(lat:string, lon:string, units:boolean){
    this.checkunits(units)
    return this.http.get("https://api.openweathermap.org/data/2.5/forecast?lat="+lat+"&lon="+lon+"&appid="+this.apiKey+"&units="+this.tempunits);
  }


  searchweather(name:string, units:boolean){
    this.checkunits(units)
    return this.http.get("https://api.openweathermap.org/data/2.5/weather?q="+name+"&appid="+this.apiKey+"&units="+this.tempunits);
  }
  forecast5(city:string, units:boolean){
    this.checkunits(units)
    return this.http.get("https://api.openweathermap.org/data/2.5/forecast?q="+city+"&appid="+this.apiKey+"&units="+this.tempunits);
  }
  checkunits(ismetric:boolean){
    if(ismetric){
      this.tempunits="metric"
    }
    else{
      this.tempunits="imperial"
    }
  }

}
