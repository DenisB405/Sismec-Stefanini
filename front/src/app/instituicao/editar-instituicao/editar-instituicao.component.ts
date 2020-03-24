import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-editar-instituicao',
  templateUrl: './editar-instituicao.component.html',
  styleUrls: ['./editar-instituicao.component.scss']
})
export class EditarInstituicaoComponent implements OnInit {

  errorsCodigo: Array<string> = [];
  errors: Array<string> = [];
  cont: number = 0;
  InstituicaoForm: FormGroup;
  constructor(
    private formBuilder: FormBuilder,
    private http: Http,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  public mascaraCodigo = [/[1-9]/, /\d/, /\d/, /\d/, /\d/];
  ngOnInit() {
    this.InstituicaoForm = this.formBuilder.group({
      codigo: [1, [Validators.required, Validators.maxLength(5)]],
      descricao: [null, [Validators.required, Validators.maxLength(255)]]
    });
  }

  mascaraCod(num: string) {

    if (num.length == 0)
      return [""];
    if (num.length == 1)
      return [/[1-9]/, ""];
    if (num.length == 2)
      return [/[1-9]/, /\d/, ""]
    if (num.length == 3)
      return [/[1-9]/, /\d/, /\d/, ""]
    if (num.length == 4)
      return [/[1-9]/, /\d/, /\d/, /\d/, ""]
    if (num.length == 5)
      return [/[1-9]/, /\d/, /\d/, /\d/, /\d/];
  }

  isDisabled(campo) {

    this.InstituicaoForm.get(campo).disable();

  }

  onEdit(codigo) {
    this.router.navigate(['instituicao/editarinstituicao', codigo], { relativeTo: this.route });
  }
  onSubmit() {
    this.errorsCodigo = [];

    //TODO:Use EventEmitter with form value
    this.validaCodigo();
    if (this.InstituicaoForm.get('codigo')) {
      //update
    } else {
      //error
    }
    // return this.http.put('#', JSON.stringify(this.InstituicaoForm.value))
    //   .map(response => response)
    //   .subscribe(
    //     dados => {
    //       console.log(dados);
    //       this.InstituicaoForm.value.reset();
    //     },
    //     (error: any) => alert('erro')
    //   );
  }

  // update(candidato) {
  //   return this.http.put()
  // }

  validaCodigo() {
    if (this.InstituicaoForm.get('codigo').errors) {
      if (this.InstituicaoForm.get('codigo').value == null)
        this.errorsCodigo.push("Campo Obrigatório!!!!!");
    }
    console.log(this.InstituicaoForm.get('codigo').errors);
    console.log(this.errorsCodigo);
  }
}
