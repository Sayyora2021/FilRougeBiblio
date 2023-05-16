import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateAuteursComponent } from './update-auteurs.component';

describe('UpdateAuteursComponent', () => {
  let component: UpdateAuteursComponent;
  let fixture: ComponentFixture<UpdateAuteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateAuteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateAuteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
