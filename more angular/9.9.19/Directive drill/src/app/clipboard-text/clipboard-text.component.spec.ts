import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClipboardTextComponent } from './clipboard-text.component';

describe('ClipboardTextComponent', () => {
  let component: ClipboardTextComponent;
  let fixture: ComponentFixture<ClipboardTextComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClipboardTextComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClipboardTextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
