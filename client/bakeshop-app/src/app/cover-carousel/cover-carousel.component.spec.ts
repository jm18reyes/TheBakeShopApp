import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoverCarouselComponent } from './cover-carousel.component';

describe('CoverCarouselComponent', () => {
  let component: CoverCarouselComponent;
  let fixture: ComponentFixture<CoverCarouselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CoverCarouselComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CoverCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
