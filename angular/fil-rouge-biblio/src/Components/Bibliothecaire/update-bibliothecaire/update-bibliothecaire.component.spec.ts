import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateBibliothecaireComponent } from './update-bibliothecaire.component';

describe('UpdateBibliothecaireComponent', () => {
  let component: UpdateBibliothecaireComponent;
  let fixture: ComponentFixture<UpdateBibliothecaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateBibliothecaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateBibliothecaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
