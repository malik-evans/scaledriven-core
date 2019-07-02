import {Component, OnInit} from '@angular/core';
import {
  EntityCollection, EntityCollectionService,
  EntityCollectionServiceElements,
  EntityCollectionServiceFactory, EntityServices
} from "@ngrx/data";
import {User} from "./entity/user/user.model";
import {KnowEnittyNames} from "./entity/entity.metadata";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'ClientApp';

  private userService: EntityCollectionService<User>;

  constructor(private serviceFactory: EntityServices) {
    this.userService = this.serviceFactory.getEntityCollectionService(KnowEnittyNames.User);
  }

  ngOnInit(): void {
    this.userService.addOneToCache({ name: "mark", id: "2" });
  }

}
