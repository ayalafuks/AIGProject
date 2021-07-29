import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categories:any;

  constructor(private http:HttpClient) { }

   getCategories(){
return this.http.get('https://localhost:5001/api/Categories');
  }
}
