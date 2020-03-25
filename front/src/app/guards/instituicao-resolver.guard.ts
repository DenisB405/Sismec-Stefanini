import { Injectable } from '@angular/core';
import { CanActivate, Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Instituicao } from '../Instituicao/instituicao/instituicao'
import { of, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InstituicaoResolverGuard implements Resolve<Instituicao> {

  constructor() { }
  resolve(route: import("@angular/router").ActivatedRouteSnapshot, state: import("@angular/router").RouterStateSnapshot) : Observable<Instituicao> {
    if (route.params && route.params['codigo']){
      return 
    }
    return of({
      codigo: null,
      descricao: null
    });
  }
  private isAuthenticated: boolean = false;

  canActivate() {
    return this.isAuthenticated;
  }
}