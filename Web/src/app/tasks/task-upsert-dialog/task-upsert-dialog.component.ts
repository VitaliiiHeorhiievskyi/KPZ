import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { TaskStatus } from '../tasks.model';
import { TaskDialogData } from './task-upsert-dialog.model';

@Component({
  selector: 'app-task-upsert-dialog',
  templateUrl: './task-upsert-dialog.component.html',
  styleUrls: ['./task-upsert-dialog.component.scss']
})
export class TaskUpsertDialogComponent {
  constructor(
    private dialogRef: MatDialogRef<TaskUpsertDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: TaskDialogData,
  ) {}

  public Status = TaskStatus;


  public submit(): void {
    if (this.data.form.valid) this.dialogRef.close({ isSubmit: true });
  }

  public getEnums(): string[] {
    return Object.keys(TaskStatus).filter((item) => {
      return isNaN(Number(item));
  });
  }
  public cancel(): void {
    this.dialogRef.close({ isSubmit: false });
  }
}
