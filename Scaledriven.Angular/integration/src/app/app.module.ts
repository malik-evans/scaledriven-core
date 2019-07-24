import { BrowserModule } from '@angular/platform-browser';
import {ApplicationRef, DoBootstrap, Injector, NgModule} from '@angular/core';

import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { createCustomElement } from "@angular/elements";
import { UserComponent } from "./user/user.component";
import { UserModule } from "./user/user.module";
import { DashboardModule } from "./dashboard/dashboard.module";
import {DashboardComponent} from "./dashboard/dashboard.component";


/**
 * Bootstraps integration component, acting as browserPolyfill,
 * supporting the use for custom elements via entryComponents
 */
@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    UserModule,
    DashboardModule
  ],
  entryComponents: [UserComponent, DashboardComponent]
})
export class AppModule implements DoBootstrap {

  constructor(private injector: Injector) {
    let DashboardElement =  createCustomElement(DashboardComponent, { injector });
    customElements.define('s-dashboard', DashboardElement);

    let UserElement =  createCustomElement(UserComponent, { injector });
    customElements.define('app-user', UserElement);
  }

  ngDoBootstrap(appRef: ApplicationRef): void { }

}
