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
    this.Request = new instituicaoRequest();
    this.Request.page = 1;
    this.Request.quantidade = 10;
    this.pageChanged(this.Request.page)
  }
  pageChanged(event: number){
    this.Request.page = event;
    this.list();
    this.config = {
      itemsPerPage: this.quantidadeDeRegistros,
      currentPage: 1  
  }; 
  console.log(this.Response.instituicoes);
  }
  list(){
    this.service.list(this.Request)
    .subscribe(dados =>this.Response = dados);
  }
  ngOnInit() { 
    this.list();
  }
}