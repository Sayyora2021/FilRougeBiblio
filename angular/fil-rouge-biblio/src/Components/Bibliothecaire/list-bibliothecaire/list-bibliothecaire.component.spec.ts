import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListBibliothecaireComponent } from './list-bibliothecaire.component';

describe('ListBibliothecaireComponent', () => {
  let component: ListBibliothecaireComponent;
  let fixture: ComponentFixture<ListBibliothecaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListBibliothecaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListBibliothecaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
