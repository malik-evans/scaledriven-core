import { EntityMetadataMap } from '@ngrx/data';

export enum KnowEnittyNames {
    User = "User"
}

const entityMetadata: EntityMetadataMap = {
  [KnowEnittyNames.User]: {}
};

// because the plural of "hero" is not "heros"
const pluralNames = { [KnowEnittyNames.User]: "Users" };

export const entityConfig = {
  entityMetadata,
  pluralNames
};
