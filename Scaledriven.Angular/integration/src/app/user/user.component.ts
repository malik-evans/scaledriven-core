import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-user',
  template: `
    <p>user works dude</p>
  `,
})
export class UserComponent implements OnInit {

  constructor(private http: HttpClient) {}

  ngOnInit() {
    console.log('[User]');
  }

}
