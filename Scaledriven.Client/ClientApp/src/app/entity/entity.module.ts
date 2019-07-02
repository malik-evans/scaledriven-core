import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {EntityDataModule} from "@ngrx/data";
import {entityConfig} from "./entity.metadata";
import {EffectsModule} from "@ngrx/effects";
import {StoreDevtoolsModule} from "@ngrx/store-devtools";
import {StoreModule} from "@ngrx/store";
import {HttpClientModule} from "@angular/common/http";
import {environment} from "../../environments/environment";

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HttpClientModule,
    StoreModule.forRoot({ }),
    EffectsModule.forRoot([]),
    EntityDataModule.forRoot(entityConfig),
    StoreDevtoolsModule.instrument({ maxAge: 25, logOnly: environment.production }),
  ],
  exports: [
    HttpClientModule,
    StoreModule,
    EffectsModule,
    EntityDataModule,
    StoreDevtoolsModule
  ]
})
export class EntityModule { }
