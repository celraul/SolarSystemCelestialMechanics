import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { NotLoggedInTemplateComponent } from './templates/not-loggedin-template/not-loggedin-template.component';
import { NotFoundPageComponent } from './pages/not-found-page/not-found-page.component';
import { LoggedInTemplateComponent } from './templates/loggedin-template/loggedin-template.component';

const APP_ROUTES: Routes = [
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',
  },
  {
    path: 'login',
    component: NotLoggedInTemplateComponent,
    loadChildren: () =>
      import('./pages/login/login.module').then((m) => m.LoginModule),
  },
  {
    path: 'dashboard',
    component: LoggedInTemplateComponent,
    loadChildren: () =>
      import('./pages/dashboard/dashboard.module').then(
        (m) => m.DashboardModule
      ),
  },
  {
    path: '**',
    component: NotFoundPageComponent,
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(APP_ROUTES, {
      preloadingStrategy: PreloadAllModules,
      useHash: true,
    }),
  ],
  declarations: [],
  exports: [],
  providers: [],
})
export class AppRoutingModule {}
