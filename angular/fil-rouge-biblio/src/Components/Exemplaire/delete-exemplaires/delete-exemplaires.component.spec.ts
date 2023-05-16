import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteExemplairesComponent } from './delete-exemplaires.component';

describe('DeleteExemplairesComponent', () => {
  let component: DeleteExemplairesComponent;
  let fixture: ComponentFixture<DeleteExemplairesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteExemplairesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteExemplairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
