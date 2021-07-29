import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {

  favorites:any;
  constructor(private http:HttpClient) { }

  getFavorites(){
   return this.http.get("https://localhost:5001/api/Favorites");
  }

  addToFavorites(lecture:any){
   return this.http.post('https://localhost:5001/api/Favorites/add',lecture)

  }

  removeFromFavorites(lecture:any){
   return this.http.post('https://localhost:5001/api/Favorites/remove',lecture);
  }
}
