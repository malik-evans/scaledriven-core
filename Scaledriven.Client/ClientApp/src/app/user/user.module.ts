import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './user.component';
import {UserResolver} from './user.model';


@NgModule({
  declarations: [UserComponent],
  imports: [
    CommonModule
  ],
  providers: [UserResolver],
  exports: [ UserComponent]
})
export class UserModule { }
