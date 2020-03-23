import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-instituicao',
  templateUrl: './instituicao.component.html',
  styleUrls: ['./instituicao.component.scss']
})

export class InstituicaoComponent implements OnInit {
  config: any;
  constructor() {
    this.config = {
      itemsPerPage: 10,
      currentPage: 1
    }; 
  }
  pageChanged(event){
    this.config.currentPage = event;
  }
  ngOnInit() { }
}