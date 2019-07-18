import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { RouterModule } from "@angular/router";
import { PublisherDirective } from './publisher.directive';
import { NotificationDirective } from './notification.directive';

@NgModule({
  declarations: [DashboardComponent, PublisherDirective, NotificationDirective],
  imports: [
    CommonModule,
    RouterModule.forRoot([])
  ],
  exports: [PublisherDirective, NotificationDirective]
})
export class DashboardModule { }
