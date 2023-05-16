import { TestBed } from '@angular/core/testing';

import { MotclefsService } from './motclefs.service';

describe('MotclefsService', () => {
  let service: MotclefsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MotclefsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
