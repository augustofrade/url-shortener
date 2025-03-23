import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectionHandlerComponent } from './redirection-handler.component';

describe('RedirectionHandlerComponent', () => {
  let component: RedirectionHandlerComponent;
  let fixture: ComponentFixture<RedirectionHandlerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RedirectionHandlerComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RedirectionHandlerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
