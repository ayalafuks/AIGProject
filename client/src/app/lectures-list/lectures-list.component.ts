import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { from } from 'rxjs';
import {LectureService} from '../lecture.service';

@Component({
  selector: 'app-lectures-list',
  templateUrl: './lectures-list.component.html',
  styleUrls: ['./lectures-list.component.css']
})
export class LecturesListComponent implements OnInit {
id:any;
lectures:any;
  constructor( private router: Router, private route: ActivatedRoute,private lectureService:LectureService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getLactures();
});

}

getLactures(){
  this.lectureService.getLectureByCategoryId(this.id).subscribe(res=>{
    this.lectures=res;
  })
}

}
