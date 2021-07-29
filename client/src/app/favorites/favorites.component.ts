import { Component, OnInit } from '@angular/core';
import {FavoriteService} from '../favorite.service';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {
favorites:any;
  constructor(private favoriteService:FavoriteService,private http:HttpClient) { }

  ngOnInit(){
   this.getFavorites();
  }

  getFavorites(){
    this.favoriteService.getFavorites().subscribe(res=>{
      this.favorites=res;
    })
  }

  remove(){
    this.getFavorites();
}

}
