import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { FavoritesComponent } from './favorites/favorites.component';
import { HomeComponent } from './home/home.component';
import { LecturesListComponent } from './lectures-list/lectures-list.component';

const routes: Routes = [
  {path:"",component:HomeComponent},
  {path:"favorites",component:FavoritesComponent},
  {path:"categories",component:CategoryListComponent},
  {path:"categories/:id",component:LecturesListComponent},
  {path:"**",component:HomeComponent,pathMatch:'full'},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
