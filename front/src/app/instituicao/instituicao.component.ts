import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms';
import { Http } from '@angular/http';
import { Observable, Subject } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Component({
  selector: 'app-instituicao',
  templateUrl: './instituicao.component.html',
  styleUrls: ['./instituicao.component.scss']
})

export class InstituicaoComponent implements OnInit {
  errorsCodigo: Array<string> = [];
  errors: Array<string> = [];
  cont : number = 0;
  InstituicaoForm: FormGroup;
  constructor(
    private formBuilder: FormBuilder,
    public http: Http
  ) {

  }
  public mascaraCodigo = [/[1-9]/,/\d/, /\d/, /\d/, /\d/];
  ngOnInit() {
  
    this.InstituicaoForm = this.formBuilder.group({
      codigo: [null, [Validators.required, Validators.maxLength(5)]],
      descricao: [null, [Validators.required, Validators.maxLength(255)]]
    });
  }
  mascaraCod(num : string){

    if(num.length==0)
      return [""];
    if(num.length==1)
      return [/[1-9]/,""];
    if(num.length==2)
      return [/[1-9]/,/\d/,""]
    if(num.length==3)
      return [/[1-9]/,/\d/,/\d/,""]
    if(num.length==4)
      return [/[1-9]/,/\d/,/\d/,/\d/,""]
    if(num.length==5)
      return [/[1-9]/,/\d/, /\d/, /\d/, /\d/];
    
  }
  onSubmit() {
    this.errorsCodigo = [];
    // //Deep Copy
    // const result: InstituicaoComponent = Object.assign({}, this.InstituicaoForm.value);
    // result.InstituicaoForm = Object.assign({}, result.InstituicaoForm);

    //TODO: Use EventEmitter with form value
    console.log(this.InstituicaoForm.value);
    this.validaCodigo();
    if(1!-1){
    this.http.post('#', JSON.stringify(this.InstituicaoForm.value))
                  .map(res => res)
                  .subscribe(dados =>{
                    console.log(dados);
                    this.InstituicaoForm.reset();
                  },
                  (error:any) => alert('erro'));
    }
  }
  
  validaCodigo(){
          if(this.InstituicaoForm.get('codigo').errors){
            if(this.InstituicaoForm.get('codigo').value==null)
              this.errorsCodigo.push("Campo Obrigatório!!!!!");
          }
            console.log(this.InstituicaoForm.get('codigo').errors);
            console.log(this.errorsCodigo);
  }

  onReset() {
    this.InstituicaoForm.reset();
  }
}
