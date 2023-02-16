import { ActionReducerMap, createFeatureSelector, createSelector, select } from "@ngrx/store";
import * as fromItems from './reducers/item.reducer'

export const featureName = "resources";

export interface FeatureInterface {
    items: fromItems.ItemState
}

export const reducers: ActionReducerMap<FeatureInterface> = {
    items: fromItems.reducer
};

// 1. Feature Select
const selectFeature = createFeatureSelector<FeatureInterface>(featureName);

// 2. Selector per branch of the feature(1 - items)
const selectItemsBranch = createSelector(selectFeature, f => f.items);

// 3. Helpers

export const { selectAll: selectItemsArray } = fromItems.adapter.getSelectors(selectItemsBranch);