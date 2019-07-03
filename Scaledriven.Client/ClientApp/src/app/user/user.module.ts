import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {UserResolver} from './user.model';


@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: [UserResolver],
  exports: []
})
export class UserModule { }
