import { Component, OnInit } from '@angular/core';

export interface NavigationModel {
  items: [
    { label: string, link: string }
  ]
}

@Component({
  selector: 'app-dashboard',
  template: `
    <div class="ui grid">
      
      <div class="row">
        <nav class="ui two item menu">
          <div *ngFor="let item of navigation.items" routerLink="{{ item.link }}" class="item">
            <a>{{ item.label }}</a>
          </div>
        </nav>
      </div>
      
      <div class="ui row">
        <div class="ui four wide column"></div>
        <div class="ui twelve wide column">
            <h1>Random header</h1>
           <router-outlet></router-outlet>
        </div>
      </div>
      <footer class="ui center aligned bottom attached segment">
        <h1 class="header">ScaleDriven!</h1>
      </footer>
    </div>
  `,
  styles: []
})
export class DashboardComponent{

  public navigation = {
    items: [
      { label: 'Home', link: '/' },
      { label: 'Profile', link: '/profile' }
    ]
  };
}
