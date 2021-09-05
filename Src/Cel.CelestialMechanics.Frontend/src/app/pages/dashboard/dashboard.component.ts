import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ThemePalette } from '@angular/material/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Observable } from 'rxjs/internal/Observable';
import { ElementosOrbitaisModel } from 'src/app/models/elementosOrbitais.model';
import { MecanicaCelesteService } from 'src/app/services/mecanicaCeleste.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit, OnDestroy {
  elementosOrbitais$: Observable<ElementosOrbitaisModel[]>;
  tablesHabilitadas: boolean = false;

  @ViewChild('picker') picker: any;
  public date: Date;
  public hideTime = false;
  public disableMinute = false;
  public disabled = false;
  public showSpinners = true;
  public showSeconds = false;
  public touchUi = false;
  public enableMeridian = false;
  public minDate: Date;
  public maxDate: Date;
  public stepHour = 1;
  public stepMinute = 1;
  public stepSecond = 1;
  public color: ThemePalette = 'primary';
  public dateControl = new FormControl();

  //material table
  displayedColumnsElementosOrbitais: string[] = [
    'nome',
    'tempo',
    'longitudeNodoAscendente',
    'inclinacaoPlanoOrbitalTerra',
    'argumentoPerielio',
    'semiEixoMaiorOrbita',
    'excentricidadeOrbita',
    'anomaliaMedia',
    'anomaliaExentrica',
    'anomaliaVerdadeira',
    'distanciaPlanetaSol',
  ];
  displayedColumnsCoordenadas: string[] = [
    'nome',
    'x',
    'y',
    'z',
    'lambda',
    'beta',
  ];
  dataSourceElementosOrbitais: MatTableDataSource<ElementosOrbitaisModel>;
  dataSourceCoordenadas: MatTableDataSource<ElementosOrbitaisModel>;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  constructor(private mecanicaCelesteService: MecanicaCelesteService) {}

  ngOnInit(): void {
    this.dateControl.setValue(new Date(2197, 9, 2, 5, 25, 0));
  }

  initForm() {}

  ngOnDestroy(): void {}

  calcularElementosOrbitais() {
    if (!this.dateControl.valid || !this.dateControl.value) return;

    this.mecanicaCelesteService
      .get(this.dateControl.value)
      .subscribe((response) => {
        this.tablesHabilitadas = true;
        this.dataSourceCoordenadas = this.dataSourceElementosOrbitais =
          new MatTableDataSource(response);
      });
  }
}
