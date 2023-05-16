import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsExemplairesComponent } from './details-exemplaires.component';

describe('DetailsExemplairesComponent', () => {
  let component: DetailsExemplairesComponent;
  let fixture: ComponentFixture<DetailsExemplairesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsExemplairesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsExemplairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
