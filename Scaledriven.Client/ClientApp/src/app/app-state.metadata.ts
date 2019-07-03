import { EntityMetadataMap } from '@ngrx/data';

export enum KnowEntityNames {
    User = "User"
}

const appStateMetadata: EntityMetadataMap = {
  [KnowEntityNames.User]: {}
};

// because the plural of "hero" is not "heros"
const pluralNames = { [KnowEntityNames.User]: "Users" };

export const entityConfig = {
  entityMetadata: appStateMetadata,
  pluralNames
};
