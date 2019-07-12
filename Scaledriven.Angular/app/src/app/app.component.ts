import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-root',
  template: `
        <h1>App</h1>
        <router-outlet></router-outlet>
  `,
})
export class AppComponent implements OnInit {

  constructor(private _http: HttpClient) {}

  ngOnInit(): void {
    this._http.get('swagger/v1/swagger.json')
      .toPromise()
      .then( val => {
        console.log(val);
      });
  }
}
