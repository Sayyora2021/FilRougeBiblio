import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListThemesComponent } from './list-themes.component';

describe('ListThemesComponent', () => {
  let component: ListThemesComponent;
  let fixture: ComponentFixture<ListThemesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListThemesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListThemesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
