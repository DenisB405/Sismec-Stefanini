import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { NavegationBarComponent } from './navegation-bar/navegation-bar.component';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { MenuLateralComponent } from './menu-lateral/menu-lateral.component';
import { InstituicaoComponent } from './instituicao/instituicao.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { HttpModule } from '@angular/http';
import { TextMaskModule } from 'angular2-text-mask';
import { CadastroIntituicaoComponent } from './Instituicao/cadastro-intituicao/cadastro-intituicao.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FooterComponent,
    NavegationBarComponent,
    MenuLateralComponent,
    InstituicaoComponent,
    CadastroIntituicaoComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFontAwesomeModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    TextMaskModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
