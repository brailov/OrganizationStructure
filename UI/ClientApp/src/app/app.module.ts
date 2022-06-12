import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './Employee/employee.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { WorkerDetailsComponent } from './Workers/worker-details.componnent';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ManagerReportComponent } from './Workers/Dialog/managerreport.component';
import { MatDialogModule  } from "@angular/material";
import { OverlayModule } from '@angular/cdk/overlay';
import { WorkerService } from './services/WorkerService';
import { TaskReportComponent } from './Workers/Dialog/taskreport.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EmployeeComponent,
    FetchDataComponent,
    WorkerDetailsComponent,
    ManagerReportComponent,
    TaskReportComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    OverlayModule,
    ReactiveFormsModule,
    MatDialogModule,
    RouterModule.forRoot([
      { path: '', component: FetchDataComponent, pathMatch: 'full' },   
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'home', component: HomeComponent },
      { path: 'workerdetails', component: WorkerDetailsComponent },
   // { path: '**', component: FetchDataComponent },     
    ]),
    BrowserAnimationsModule
  ],
  providers: [WorkerService],
  bootstrap: [AppComponent],
  entryComponents: [ManagerReportComponent, TaskReportComponent]
})
export class AppModule { }
