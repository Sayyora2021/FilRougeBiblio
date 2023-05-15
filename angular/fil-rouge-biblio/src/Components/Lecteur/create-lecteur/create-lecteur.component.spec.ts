import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateLecteurComponent } from './create-lecteur.component';

describe('CreateLecteurComponent', () => {
  let component: CreateLecteurComponent;
  let fixture: ComponentFixture<CreateLecteurComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateLecteurComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateLecteurComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
