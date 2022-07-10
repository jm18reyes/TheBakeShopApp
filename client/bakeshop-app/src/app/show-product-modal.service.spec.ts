import { TestBed } from '@angular/core/testing';

import { ShowProductModalService } from './show-product-modal.service';

describe('ShowProductModalService', () => {
  let service: ShowProductModalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShowProductModalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
