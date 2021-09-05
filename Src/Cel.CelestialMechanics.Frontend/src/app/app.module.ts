import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing.module';
import { NotFoundPageComponent } from './pages/not-found-page/not-found-page.component';
import { SharedModule } from './shared/shared.module';
import { LoggedInTemplateComponent } from './templates/loggedin-template/loggedin-template.component';
import { NotLoggedInTemplateComponent } from './templates/not-loggedin-template/not-loggedin-template.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FooterComponent } from './shared/components/footer/footer.component';
import { NavComponent } from './shared/components/nav/nav.component';
import { SidebarComponent } from './shared/components/sidebar/sidebar.component';

@NgModule({
  declarations: [
    AppComponent,
    NotLoggedInTemplateComponent,
    LoggedInTemplateComponent,
    NotFoundPageComponent,
    NavComponent,
    SidebarComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    SharedModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
