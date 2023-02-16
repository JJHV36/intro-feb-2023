import { createActionGroup, emptyProps } from "@ngrx/store";

export const LearningResourcesEvents = createActionGroup({
    source: 'Learning Resources Events',
    events: {
        entered: emptyProps()
    }
})