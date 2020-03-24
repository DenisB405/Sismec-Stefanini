import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CadastroIntituicaoComponent } from './Instituicao/cadastro-intituicao/cadastro-intituicao.component';
import { InstituicaoComponent } from './Instituicao/instituicao/instituicao.component';
import { EditarInstituicaoComponent } from './Instituicao/editar-instituicao/editar-instituicao.component';


const routes: Routes = [
  {
    path: '', component: HomeComponent
  },
  {
    path: 'Home', component: HomeComponent
  },
  {
    path: 'Instituicao', component: InstituicaoComponent
  },
  {
    path: 'instituicao/cadastroinstituicao', component: CadastroIntituicaoComponent
  },
  {
    path: 'instituicao/editarinstituicao/:id', component: EditarInstituicaoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
