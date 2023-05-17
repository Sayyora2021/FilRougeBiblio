import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEmpruntsComponent } from './create-emprunts.component';

describe('CreateEmpruntsComponent', () => {
  let component: CreateEmpruntsComponent;
  let fixture: ComponentFixture<CreateEmpruntsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateEmpruntsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateEmpruntsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
