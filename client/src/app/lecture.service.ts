import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LectureService {

  constructor(private http:HttpClient) { }

  getLectureByCategoryId(id:number){
    return this.http.get('https://localhost:5001/api/Lectures/'+id);
  }
}
