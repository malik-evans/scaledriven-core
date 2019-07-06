import { NgModule } from '@angular/core';
import { CoreComponent } from './core.component';
import { NgxsModule } from "@ngxs/store";
import { NgxsDispatchPluginModule } from "@ngxs-labs/dispatch-decorator";
import { NgxsReduxDevtoolsPluginModule } from "@ngxs/devtools-plugin";
import { NgxsEmitPluginModule } from "@ngxs-labs/emitter";
import { NgxsLoggerPluginModule } from "@ngxs/logger-plugin";

@NgModule({
  declarations: [CoreComponent],
  imports: [
    NgxsModule.forRoot([]),
    NgxsDispatchPluginModule.forRoot(),
    NgxsReduxDevtoolsPluginModule.forRoot(),
    NgxsEmitPluginModule.forRoot(),
    NgxsLoggerPluginModule.forRoot()
  ],
  exports: [
    CoreComponent,
    NgxsModule,
    NgxsDispatchPluginModule,
    NgxsReduxDevtoolsPluginModule,
    NgxsEmitPluginModule,
    NgxsLoggerPluginModule
  ]
})
export class CoreModule { }
