import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroIntituicaoComponent } from './cadastro-intituicao.component';

describe('CadastroIntituicaoComponent', () => {
  let component: CadastroIntituicaoComponent;
  let fixture: ComponentFixture<CadastroIntituicaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastroIntituicaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroIntituicaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
