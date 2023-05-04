import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeModel } from './employee.model';

describe('EmployeeModel', () => {
  let component: EmployeeModel;
  let fixture: ComponentFixture<EmployeeModel>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeeModel ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeeModel);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
