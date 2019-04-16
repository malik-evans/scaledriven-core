import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {NgxsModule} from "@ngxs/store";
import {NgxsEmitPluginModule} from "@ngxs-labs/emitter";
import {NgxsDispatchPluginModule} from "@ngxs-labs/dispatch-decorator";
import {NgxsLoggerPluginModule} from "@ngxs/logger-plugin";
import {NgxsStoragePluginModule} from "@ngxs/storage-plugin";
import {NgxsRouterPluginModule} from "@ngxs/router-plugin";
import {NgxsReduxDevtoolsPluginModule} from "@ngxs/devtools-plugin";

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    NgxsModule.forRoot(),
    NgxsEmitPluginModule.forRoot(),
    NgxsDispatchPluginModule.forRoot(),
    NgxsLoggerPluginModule.forRoot(),
    NgxsStoragePluginModule.forRoot(),
    NgxsRouterPluginModule.forRoot(),
    NgxsReduxDevtoolsPluginModule.forRoot()
  ],
  exports: [
    CommonModule,
    NgxsModule,
    NgxsEmitPluginModule,
    NgxsDispatchPluginModule,
    NgxsLoggerPluginModule,
    NgxsStoragePluginModule,
    NgxsRouterPluginModule,
    NgxsReduxDevtoolsPluginModule
  ]
})
export class StateModule { }
