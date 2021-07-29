import { Component, OnInit } from '@angular/core';
import {CategoryService} from '../category.service';
import {HttpClient} from '@angular/common/http';
import { Router } from '@angular/router';


@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  categories:any;
  lectures:any;

  constructor(private http:HttpClient,private router:Router,private categoryService:CategoryService) { }

  ngOnInit() {
    this.categoryService.getCategories().subscribe(res=>{
      this.categories=res;
    })
  }

  openLecture(categoryId:any)
  {
    this.router.navigateByUrl('/categories/'+categoryId);
  }

}
