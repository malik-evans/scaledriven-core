import {ActivatedRouteSnapshot, Resolve, RouterStateSnapshot} from '@angular/router';
import {Observable, of} from 'rxjs';
import * as Faker from 'faker';
import {Injectable} from '@angular/core';

export interface User {
  id: string;
  name: string;
}

@Injectable()
export class UserResolver implements Resolve<User[]> {
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<User[]> | Promise<User[]> | User[] {
      const userCollection = new Array<User>(20)
                                  .fill({ name: null, id: null })
                                  .map( u => ({
                                      name: Faker.name.findName(),
                                      id: Faker.random.number(30).toString()
                                  }));
      return of(userCollection);
  }

}
