import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateAuteursComponent } from './create-auteurs.component';

describe('CreateAuteursComponent', () => {
  let component: CreateAuteursComponent;
  let fixture: ComponentFixture<CreateAuteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateAuteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateAuteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
