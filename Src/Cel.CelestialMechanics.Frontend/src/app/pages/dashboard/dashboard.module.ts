import { SharedModule } from 'src/app/shared/shared.module';
import { NgModule } from '@angular/core';
import { DashboardComponent } from './dashboard.component';
import { DashboardRoutingModule } from './dashboard.rounting.module';
import { MecanicaCelesteService } from 'src/app/services/mecanicaCeleste.service';

@NgModule({
  declarations: [DashboardComponent],
  imports: [DashboardRoutingModule, SharedModule],
  providers: [MecanicaCelesteService],
})
export class DashboardModule {}
