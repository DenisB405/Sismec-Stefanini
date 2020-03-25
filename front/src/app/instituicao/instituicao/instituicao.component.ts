import { Component, OnInit, Injectable } from '@angular/core';
import { Instituicao } from './Instituicao';
import { InstituicaoService } from './instituicao.service';
import { instituicaoRequest } from './instituicaoRequest';
import { instituicaoResponse } from './instituicaoResponse';

@Component({
  selector: 'app-instituicao',
  templateUrl: './instituicao.component.html',
  styleUrls: ['./instituicao.component.scss']
})

export class InstituicaoComponent implements OnInit {
  config: any;
  quantidadeDeRegistros: number;

  Response: instituicaoResponse;
  instituicoes: Instituicao[];
  Request : instituicaoRequest;
  constructor(private service: InstituicaoService ) {
    this.Response = new instituicaoResponse();
    this.Request = new instituicaoRequest();
    this.Request.page = 1;
    this.quantidadeDeRegistros = 10;
    this.Request.quantidade = this.quantidadeDeRegistros;
    this.config = {
      itemsPerPage: this.Request.quantidade,
      currentPage: this.Request.page
  }; 
  }
  pageChanged(event: number){
    this.Request.page = event;
    this.list();
    console.log(this.Response.listaRegistros);   
    this.config = {
      itemsPerPage: this.quantidadeDeRegistros,
      currentPage: event
  }; 
  }
  list(){
    this.service.list(this.Request)
    .subscribe(dados =>this.Response = dados);
  }
  ngOnInit() { 
    this.pageChanged(1);
    this.list();
             
  }
}