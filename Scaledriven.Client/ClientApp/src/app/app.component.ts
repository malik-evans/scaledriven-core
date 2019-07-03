import {Component, OnInit} from '@angular/core';
import {
  EntityCollection, EntityCollectionService,
  EntityCollectionServiceElements,
  EntityCollectionServiceFactory, EntityServices
} from "@ngrx/data";
import {User} from "./user/user.model";
import {KnowEntityNames} from "./app-state.metadata";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent { }
