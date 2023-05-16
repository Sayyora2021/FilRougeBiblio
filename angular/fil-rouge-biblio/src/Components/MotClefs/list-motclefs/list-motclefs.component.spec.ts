import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListMotclefsComponent } from './list-motclefs.component';

describe('ListMotclefsComponent', () => {
  let component: ListMotclefsComponent;
  let fixture: ComponentFixture<ListMotclefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListMotclefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListMotclefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
