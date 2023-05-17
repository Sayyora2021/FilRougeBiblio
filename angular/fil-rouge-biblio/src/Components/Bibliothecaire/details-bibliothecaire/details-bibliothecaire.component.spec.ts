import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsBibliothecaireComponent } from './details-bibliothecaire.component';

describe('DetailsBibliothecaireComponent', () => {
  let component: DetailsBibliothecaireComponent;
  let fixture: ComponentFixture<DetailsBibliothecaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsBibliothecaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsBibliothecaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
