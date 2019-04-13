import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SocialModule } from "./Layouts/social/social.module";
import { SharedModule } from './shared/shared.module';
import { NgxsModule} from "@ngxs/store";
import { NgxsLoggerPluginModule } from "@ngxs/logger-plugin";
import { NgxsStoragePluginModule } from "@ngxs/storage-plugin";
import { NgxsRouterPluginModule } from "@ngxs/router-plugin";
import { NgxsReduxDevtoolsPluginModule } from "@ngxs/devtools-plugin";
import { NgxsEmitPluginModule } from "@ngxs-labs/emitter";
import { NgxsDispatchPluginModule } from "@ngxs-labs/dispatch-decorator";

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SocialModule,
    SharedModule,
    NgxsModule.forRoot(),
    NgxsEmitPluginModule.forRoot(),
    NgxsDispatchPluginModule.forRoot(),
    NgxsLoggerPluginModule.forRoot(),
    NgxsStoragePluginModule.forRoot(),
    NgxsRouterPluginModule.forRoot(),
    NgxsReduxDevtoolsPluginModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
