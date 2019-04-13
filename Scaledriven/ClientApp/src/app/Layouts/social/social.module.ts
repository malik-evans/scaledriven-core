import {NgModule} from "@angular/core";
import {Menubar, MenubarModule} from "primeng/menubar";
import {SocialComponent} from "./social.component";

@NgModule({
  imports: [
    MenubarModule
  ],
  exports: [
    Menubar
  ],
  declarations: [
    SocialComponent
  ]
})
export class SocialModule {

}
