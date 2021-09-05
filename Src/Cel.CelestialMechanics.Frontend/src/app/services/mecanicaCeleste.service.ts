import { Injectable } from '@angular/core';
import { SITE_API } from '../app.consts';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ElementosOrbitaisModel } from '../models/elementosOrbitais.model';

@Injectable()
export class MecanicaCelesteService {
  constructor(private http: HttpClient) {}

  get(data: Date): Observable<ElementosOrbitaisModel[]> {
    return this.http
      .get<ElementosOrbitaisModel[]>(
        `${SITE_API}/MecanicaCeleste?data=${data.toISOString()}`
      )
      .pipe(map((response) => response));
  }
}
