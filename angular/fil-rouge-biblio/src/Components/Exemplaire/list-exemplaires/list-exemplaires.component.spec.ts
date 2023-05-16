import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListExemplairesComponent } from './list-exemplaires.component';

describe('ListExemplairesComponent', () => {
  let component: ListExemplairesComponent;
  let fixture: ComponentFixture<ListExemplairesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListExemplairesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListExemplairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
