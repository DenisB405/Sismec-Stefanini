import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms'
import {Http} from '@angular/http'

@Component({
  selector: 'app-candidato',
  templateUrl: './candidato.component.html',
  styleUrls: ['./candidato.component.scss']
})
export class CandidatoComponent implements OnInit {

  CandidatoForm :FormGroup;
  constructor(
    private formBuilder: FormBuilder,
    public http: Http
  ) { }


  ngOnInit() {
    this.CandidatoForm = this.formBuilder.group({
      nome:[null,[Validators.required,Validators.minLength(8),Validators.maxLength(55)]],
      apelido:[null,[Validators.required,Validators.minLength(5),Validators.maxLength(55)]],
      CEP:[null,[Validators.required,Validators.maxLength(7)]],
      cidade:[null,[Validators.required]],
      bairro:[null,[Validators.required]],
      numero:[null,[Validators.minLength(1),Validators.maxLength(10)]],
      email:[null,[Validators.required,Validators.email]],
      celular:[null,Validators.required,Validators.maxLength(11)],
      celularOpcional:[null,[Validators.maxLength(11)]],
      CPF:[null,[Validators.required,Validators.maxLength(11)]],
      estado:[null,[Validators.required]],
      endereco:[null,Validators.required,Validators.minLength(15),Validators.maxLength(40)],
      complemento:[null,[Validators.maxLength(40)]]
    })
  }

}
