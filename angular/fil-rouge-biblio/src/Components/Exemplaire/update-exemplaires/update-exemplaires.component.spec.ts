import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateExemplairesComponent } from './update-exemplaires.component';

describe('UpdateExemplairesComponent', () => {
  let component: UpdateExemplairesComponent;
  let fixture: ComponentFixture<UpdateExemplairesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateExemplairesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateExemplairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
