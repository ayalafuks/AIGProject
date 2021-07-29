import { Component, OnInit,Input, ApplicationRef, ChangeDetectorRef, Output, EventEmitter } from '@angular/core';
import {FavoriteService} from '../favorite.service';


@Component({
  selector: 'app-lecture',
  templateUrl: './lecture.component.html',
  styleUrls: ['./lecture.component.css']
})
export class LectureComponent implements OnInit {
  @Input() lecture: any;
  @Output() removeFavorite = new EventEmitter();
  constructor(private favoriteService:FavoriteService,private changeDetector:ChangeDetectorRef) { }

  ngOnInit(): void {
  }

  add(){
    this.favoriteService.addToFavorites(this.lecture).subscribe(res=>{
      this.lecture=res;
    });
  }

  remove(){
    this.favoriteService.removeFromFavorites(this.lecture).subscribe(res=>{
      this.lecture=res;
      this.removeFavorite.emit();
    });
  }

}
