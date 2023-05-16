import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteMotclefsComponent } from './delete-motclefs.component';

describe('DeleteMotclefsComponent', () => {
  let component: DeleteMotclefsComponent;
  let fixture: ComponentFixture<DeleteMotclefsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteMotclefsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteMotclefsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
