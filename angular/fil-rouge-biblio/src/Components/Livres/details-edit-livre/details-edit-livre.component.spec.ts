import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsEditLivreComponent } from './details-edit-livre.component';

describe('DetailsEditLivreComponent', () => {
  let component: DetailsEditLivreComponent;
  let fixture: ComponentFixture<DetailsEditLivreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsEditLivreComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsEditLivreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
