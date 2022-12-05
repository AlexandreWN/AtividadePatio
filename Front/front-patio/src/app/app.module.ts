import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AreaComponent } from './area/area.component';
import { VendaComponent } from './venda/venda.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AreaComponent,
    VendaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      {path:'',component:HomeComponent},
      {path:'area/:areaId',component:AreaComponent},
      {path:'venda/:Id/:Idcarro/:Idconcessionaria', component:VendaComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
