import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { LearningResourcesEvents } from './state/actions/learning-resources.actions';

@Component({
  selector: 'app-learning-resources',
  templateUrl: './learning-resources.component.html',
  styleUrls: ['./learning-resources.component.css']
})
export class LearningResourcesComponent {
  constructor(store: Store) {
    store.dispatch(LearningResourcesEvents.entered());
  }
}
