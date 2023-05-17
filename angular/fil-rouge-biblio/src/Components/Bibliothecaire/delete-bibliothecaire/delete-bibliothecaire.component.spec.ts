import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteBibliothecaireComponent } from './delete-bibliothecaire.component';

describe('DeleteBibliothecaireComponent', () => {
  let component: DeleteBibliothecaireComponent;
  let fixture: ComponentFixture<DeleteBibliothecaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteBibliothecaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteBibliothecaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
