import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { NavegationBarComponent } from './navegation-bar/navegation-bar.component';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { MenuLateralComponent } from './menu-lateral/menu-lateral.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { HttpModule } from '@angular/http';
import { TextMaskModule } from 'angular2-text-mask';
import { CandidatoComponent } from './candidato/candidato.component';
import { CadastroIntituicaoComponent } from './Instituicao/cadastro-intituicao/cadastro-intituicao.component';
import { InstituicaoComponent } from './Instituicao/instituicao/instituicao.component';
import { EditarInstituicaoComponent } from './Instituicao/editar-instituicao/editar-instituicao.component';
import {NgxPaginationModule} from 'ngx-pagination';
import { HttpClientModule } from '@angular/common/http';
import { ExcluirComponent } from './instituicao/Excluir/excluir.component';




@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FooterComponent,
    NavegationBarComponent,
    MenuLateralComponent,
    InstituicaoComponent,
    CandidatoComponent,
    CadastroIntituicaoComponent,
    EditarInstituicaoComponent,
    ExcluirComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFontAwesomeModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    TextMaskModule,
    NgxPaginationModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
