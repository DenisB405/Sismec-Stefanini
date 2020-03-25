import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarInstituicaoComponent } from './editar-instituicao.component';

describe('EditarInstituicaoComponent', () => {
  let component: EditarInstituicaoComponent;
  let fixture: ComponentFixture<EditarInstituicaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarInstituicaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarInstituicaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
