import { Injectable } from '@angular/core';
import { CanActivate, Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Instituicao } from '../Instituicao/instituicao/instituicao'
import { of, Observable } from 'rxjs';
import { InstituicaoService } from '../Instituicao/instituicao/Service/instituicao.service'

@Injectable({
  providedIn: 'root'
})
export class InstituicaoResolverGuard implements Resolve<Instituicao> {

  constructor(private service: InstituicaoService) { }
  resolve(route: import("@angular/router").ActivatedRouteSnapshot, state: import("@angular/router").RouterStateSnapshot): Observable<Instituicao> | Instituicao | Promise<Instituicao> {
    if (route.params && route.params['codigo']) {
      return this.service.loadByCodigo(route.params['codigo']);
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