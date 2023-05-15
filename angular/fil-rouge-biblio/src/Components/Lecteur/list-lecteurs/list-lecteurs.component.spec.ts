import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListLecteursComponent } from './list-lecteurs.component';

describe('ListLecteursComponent', () => {
  let component: ListLecteursComponent;
  let fixture: ComponentFixture<ListLecteursComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListLecteursComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListLecteursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
