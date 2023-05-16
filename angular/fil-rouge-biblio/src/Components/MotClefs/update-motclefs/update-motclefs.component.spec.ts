import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateMotclefsComponent } from './update-motclefs.component';

describe('UpdateMotclefsComponent', () => {
  let component: UpdateMotclefsComponent;
  let fixture: ComponentFixture<UpdateMotclefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateMotclefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateMotclefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
