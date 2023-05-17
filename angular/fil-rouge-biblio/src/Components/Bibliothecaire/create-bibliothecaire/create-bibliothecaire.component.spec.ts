import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateBibliothecaireComponent } from './create-bibliothecaire.component';

describe('CreateBibliothecaireComponent', () => {
  let component: CreateBibliothecaireComponent;
  let fixture: ComponentFixture<CreateBibliothecaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateBibliothecaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateBibliothecaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
