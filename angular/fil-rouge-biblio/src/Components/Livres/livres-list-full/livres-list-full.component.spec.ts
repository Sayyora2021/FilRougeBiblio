import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LivresListFullComponent } from './livres-list-full.component';

describe('LivresListFullComponent', () => {
  let component: LivresListFullComponent;
  let fixture: ComponentFixture<LivresListFullComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LivresListFullComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LivresListFullComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
