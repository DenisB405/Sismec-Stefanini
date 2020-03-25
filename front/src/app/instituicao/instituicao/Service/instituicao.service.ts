import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Instituicao } from '../Instituicao';
import { tap, take } from 'rxjs/operators';
import { instituicaoRequest } from '../InstituicaoPage/instituicaoPageRequest';
import { instituicaoResponse } from '../InstituicaoPage/instituicaoPageResponse';

@Injectable({
  providedIn: 'root'
})
export class InstituicaoService {
  private readonly API = 'https://localhost:44351/Instituicao';

  constructor(private http: HttpClient) { }
  list(request: instituicaoRequest) {
    return this.http.post<instituicaoResponse>('https://localhost:44351/Instituicao/getPagina', request);
  }

  loadByCodigo(codigo) {
    return this.http.get<Instituicao>(`${this.API}/${codigo}`).pipe(take(1));
  }

  update(instituicao) {
    instituicao.codigo = 1;
    instituicao.descricao = 'zz';
    return this.http.put(`${this.API}` + '/update', instituicao).pipe(take(1));
  }
}


