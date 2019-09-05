import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-game-control',
  templateUrl: './game-control.component.html',
  styleUrls: ['./game-control.component.css']
})
export class GameControlComponent {
  @Output() intervalFired = new EventEmitter<number>();

  interval;
  lastNumber = 1;

  constructor() { }

  onStartGame() {
    this.interval = setInterval(() => {
      this.intervalFired.emit(this.lastNumber);
      this.lastNumber++;
    }
      , 1000)
  }

  onStopGame() {
    clearInterval(this.interval);

  }

}
