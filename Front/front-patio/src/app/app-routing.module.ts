import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AreaComponent } from './area/area.component';
import { VendaComponent } from './venda/venda.component';

const routes: Routes = [
  {path:'area', component:AreaComponent},
  {path:'venda', component:VendaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
