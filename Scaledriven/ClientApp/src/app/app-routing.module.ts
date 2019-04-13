import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {SocialComponent} from "./Layouts/social/social.component";

const routes: Routes = [
  {
    path: '',
    component: SocialComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
