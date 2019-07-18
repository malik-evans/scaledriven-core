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
        <div class="sixteen wide column">
          <nav class="ui green inverted large menu">
            <div *ngFor="let item of navigation.items" routerLink="{{ item.link }}" class="item">
              <a>{{ item.label }}</a>
            </div>
          </nav>
        </div>
      </div>
      
      <div class="row" [style.height.px]="style.height">
        <div class="four wide column">
          <div class="ui segment" *notification="let notification">
               <div class="content" *appPublisher="let ps">
                 <ul>
                   <li *ngFor="let message of notification.getMessages()">
                     {{ message }}
                   </li>
                 </ul>
                 <button 
                    class="ui green button"
                    (click)="ps.publisher.publish()">
                      Publish
                 </button>
              </div>
          </div>
        </div>
          
        <div class="twelve wide column">
          <div class="ui green segment">
            <h1 class="ui green header">Segmentation</h1>
          </div>
          <router-outlet></router-outlet>
        </div>
          
      </div>

      <footer class="ui center aligned bottom attached green inverted segment">
        <h1 class="header">ScaleDriven!</h1>
      </footer>
    </div>
  `,
  styles: []
})
export class DashboardComponent {

  public navigation = {
    items: [
      { label: 'Home', link: '/' },
      { label: 'Profile', link: '/profile' }
    ]
  };

  public style: { height: number } = { height: 700 }

  log(model: any) {
    console.log({ model: model });
  }
}
