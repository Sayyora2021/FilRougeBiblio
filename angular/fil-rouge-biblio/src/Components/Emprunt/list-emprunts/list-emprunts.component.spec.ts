import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmpruntsComponent } from './list-emprunts.component';

describe('ListEmpruntsComponent', () => {
  let component: ListEmpruntsComponent;
  let fixture: ComponentFixture<ListEmpruntsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmpruntsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmpruntsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
