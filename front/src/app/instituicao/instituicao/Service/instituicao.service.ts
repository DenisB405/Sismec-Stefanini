import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Instituicao } from '../Instituicao';
import { tap, take } from 'rxjs/operators';
import { instituicaoRequest } from '../InstituicaoPage/instituicaoPageRequest';
import { instituicaoResponse } from '../InstituicaoPage/instituicaoPageResponse';
import { FormGroup } from '@angular/forms';

var httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class InstituicaoService {
  private readonly API = 'https://localhost:44351/Instituicao';
  instituicao : Instituicao;
  constructor(private http: HttpClient) { 
    this.instituicao = new Instituicao();
  }

  list(request: instituicaoRequest) {
    return this.http.post<instituicaoResponse>('https://localhost:44351/Instituicao/getPagina', request, httpOptions);
  }

  loadByCodigo(codigo) {
    
    return this.http.get<Instituicao>(`${this.API}` + '/getInstituicao/' + `${codigo}`).pipe(take(1));
  }

  update(codigo:number,descricao:string) {
    this.instituicao.codigo = codigo;
    this.instituicao.descricao = descricao;
    return this.http.put(`${this.API}` + '/update', this.instituicao).pipe(take(1));
  }
}


