import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyHoursComponent } from './my-hours.component';

describe('MyHoursComponent', () => {
  let component: MyHoursComponent;
  let fixture: ComponentFixture<MyHoursComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyHoursComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyHoursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
