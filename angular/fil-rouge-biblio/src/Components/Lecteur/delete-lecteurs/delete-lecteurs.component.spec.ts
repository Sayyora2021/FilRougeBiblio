import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteLecteursComponent } from './delete-lecteurs.component';

describe('DeleteLecteursComponent', () => {
  let component: DeleteLecteursComponent;
  let fixture: ComponentFixture<DeleteLecteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteLecteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteLecteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
