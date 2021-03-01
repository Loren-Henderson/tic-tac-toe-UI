import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
@Component({
  selector: 'app-game-tile',
  templateUrl: './game-tile.component.html',
  styleUrls: ['./game-tile.component.css'],
})
export class GameTileComponent implements OnInit {
  @Output() tileClickEvent = new EventEmitter();

  @Input() sign: string;
  @Input() x: number;
  @Input() y: number;
  @Input() isWinning: boolean;

  constructor() {}

  ngOnInit(): void {}

  clickTile() {
    if (this.sign == '') {
      console.log("github deployment");
      this.tileClickEvent.emit({ x: this.x, y: this.y });
    }
  }
}
