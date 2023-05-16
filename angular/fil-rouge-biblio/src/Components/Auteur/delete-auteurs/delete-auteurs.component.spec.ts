import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteAuteursComponent } from './delete-auteurs.component';

describe('DeleteAuteursComponent', () => {
  let component: DeleteAuteursComponent;
  let fixture: ComponentFixture<DeleteAuteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteAuteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteAuteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
