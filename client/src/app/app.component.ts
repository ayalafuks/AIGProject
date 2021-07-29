import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  users:any;

  constructor(private HTTP:HttpClient){}
  ngOnInit(){
   this.HTTP.get('https://localhost:5001/api/Categories').subscribe(response=>{
     this.users=response;
   })
  }
}
