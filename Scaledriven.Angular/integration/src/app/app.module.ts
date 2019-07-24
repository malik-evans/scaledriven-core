import { BrowserModule } from '@angular/platform-browser';
import {Injector, NgModule} from '@angular/core';

import { AppIntegrationComponent } from './app-integration.component';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { UserComponent } from './user.component';
import {createCustomElement} from "@angular/elements";
import {Card, CardModule} from "primeng/card";


/**
 * Bootstraps integration component, acting as browserPolyfill,
 * supporting the use for custom elements via entryComponents
 */
@NgModule({
  declarations: [
    AppIntegrationComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    CardModule
  ],
  entryComponents: [UserComponent, Card],
  bootstrap: [AppIntegrationComponent]
})
export class AppModule {

  constructor(private injector: Injector) {
    let UserElement =  createCustomElement(UserComponent, { injector });
    customElements.define('app-user', UserElement);

    let CardElement =  createCustomElement(Card, { injector });
    customElements.define('app-card', CardElement);
  }
}
