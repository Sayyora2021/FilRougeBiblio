import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateLecteursComponent } from './update-lecteurs.component';

describe('UpdateLecteursComponent', () => {
  let component: UpdateLecteursComponent;
  let fixture: ComponentFixture<UpdateLecteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateLecteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateLecteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
