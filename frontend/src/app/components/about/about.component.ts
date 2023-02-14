import { Component } from '@angular/core';
import { catchError, Observable, of, tap } from 'rxjs';
import { StatusResponseModel } from 'src/app/models/status.model';
import { StatusDataService } from 'src/app/services/status-data.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent {

  responseFromServer$!: Observable<StatusResponseModel>;
  hasError = false;
  constructor(private service: StatusDataService) { }

  getStatus() {
    this.responseFromServer$ = this.service.getStatus().pipe(
      catchError(() => {
        this.hasError = true;
        return of({ message: 'unavailable', contact: 'unavailable' })
      })
    )

  }
}
