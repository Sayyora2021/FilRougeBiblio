import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateExemplairesComponent } from './create-exemplaires.component';

describe('CreateExemplairesComponent', () => {
  let component: CreateExemplairesComponent;
  let fixture: ComponentFixture<CreateExemplairesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateExemplairesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateExemplairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
