import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { concatMap } from "rxjs";
import { applicationEvents } from "../actions/app.actions";

@Injectable()
export class ApplicationEvents {

    logErrorsToServer = createEffect(() => {
        return this.action$.pipe(
            ofType(applicationEvents.error),
            concatMap(err => this.client.post('http://logging.hypertheory.com/app-errors', err))
        )
    }, { dispatch: false });

    constructor(private action$: Actions, private client: HttpClient) { }
}