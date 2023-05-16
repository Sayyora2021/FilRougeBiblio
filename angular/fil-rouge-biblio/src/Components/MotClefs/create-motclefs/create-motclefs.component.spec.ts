import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateMotclefsComponent } from './create-motclefs.component';

describe('CreateMotclefsComponent', () => {
  let component: CreateMotclefsComponent;
  let fixture: ComponentFixture<CreateMotclefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateMotclefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateMotclefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
