import { TestBed } from '@angular/core/testing';

import { ShowContactModalService } from './show-contact-modal.service';

describe('ShowContactModalService', () => {
  let service: ShowContactModalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShowContactModalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
