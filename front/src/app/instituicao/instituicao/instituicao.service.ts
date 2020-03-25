import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Instituicao } from './Instituicao';
import { tap } from 'rxjs/operators';
import { instituicaoRequest } from './instituicaoRequest';
import { instituicaoResponse } from './instituicaoResponse';

@Injectable({
  providedIn: 'root'
})
export class InstituicaoService {
  private readonly API = 'https://localhost:44351/Instituicao';

  constructor(private http: HttpClient) { }
  list(request: instituicaoRequest){
    return this.http.post<instituicaoResponse>('https://localhost:44351/Instituicao/getPagina', request);
  }
}

