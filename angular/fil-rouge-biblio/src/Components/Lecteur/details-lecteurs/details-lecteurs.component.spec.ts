import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsLecteursComponent } from './details-lecteurs.component';

describe('DetailsLecteursComponent', () => {
  let component: DetailsLecteursComponent;
  let fixture: ComponentFixture<DetailsLecteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsLecteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsLecteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
