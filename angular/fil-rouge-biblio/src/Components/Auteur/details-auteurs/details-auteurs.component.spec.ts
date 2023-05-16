import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsAuteursComponent } from './details-auteurs.component';

describe('DetailsAuteursComponent', () => {
  let component: DetailsAuteursComponent;
  let fixture: ComponentFixture<DetailsAuteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsAuteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsAuteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
