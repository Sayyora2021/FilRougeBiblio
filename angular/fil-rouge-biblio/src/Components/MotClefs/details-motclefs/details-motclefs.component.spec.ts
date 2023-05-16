import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsMotclefsComponent } from './details-motclefs.component';

describe('DetailsMotclefsComponent', () => {
  let component: DetailsMotclefsComponent;
  let fixture: ComponentFixture<DetailsMotclefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsMotclefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsMotclefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
