import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskUpsertDialogComponent } from './task-upsert-dialog.component';

describe('TaskUpsertDialogComponent', () => {
  let component: TaskUpsertDialogComponent;
  let fixture: ComponentFixture<TaskUpsertDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TaskUpsertDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TaskUpsertDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
function beforeEach(arg0: () => Promise<void>) {
  throw new Error('Function not implemented.');
}

