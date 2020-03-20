import { NgModule} from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { InstituicaoComponent } from './instituicao/instituicao.component';


const routes: Routes = [
  {
    path:'',component:HomeComponent
  },
  {
    path:'Home',component:HomeComponent
  },
  {
    path:'Instituicao',component:InstituicaoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
